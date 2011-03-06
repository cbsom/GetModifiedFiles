using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GetModifiedFiles
{
    public partial class frmUpload : Form
    {

        private int _failedUploadCount, _completedUploadCount;

        public frmUpload()
        {
            InitializeComponent();
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "Choose a folder to save files to.";
            this.folderBrowserDialog1.SelectedPath = Properties.Settings.Default.CopyToFolder;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtFiles.Text = this.folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.CopyToFolder = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnViewFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(this.txtFiles.Text);
        }        

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(this.txtFiles.Text);
                string[] folders = Directory.GetDirectories(this.txtFiles.Text);
                if (files.Length + folders.Length == 0)
                {
                    MessageBox.Show("There are no files or directories in " + this.txtFiles.Text + ".",
                        "File upload unnecessary",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }               
                if (!this.txtFTP.Text.Trim().EndsWith("/"))
                {
                    this.txtFTP.Text += "/";
                }
                this.AddToProgress("Starting File Upload", Color.Black, true);
                this.llCancel.Visible = true;
                this.bwUpload.RunWorkerAsync(this.txtFiles.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show("File upload failed!\n" + exc.Message,
                    "File upload failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.AddToProgress("File upload failed!" + exc.Message, Color.Red, true);
            }
        }

        private void llCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.bwUpload.CancelAsync();
            AddToProgress("Cancelling upload. This may take up to a minute....", Color.Fuchsia, true);            
        }

        void bwUpload_DoWork(object sender, DoWorkEventArgs e)
        {
            var bwUpload = sender as BackgroundWorker;
            try
            {
                this._failedUploadCount = this._completedUploadCount = 0;
                this.UploadAllFilesInFolderToFtp(Convert.ToString(e.Argument), bwUpload, e);
            }
            catch (Exception ex)
            {
                bwUpload.ReportProgress(0, "File upload failed. " + ex.Message);
            }
        }

        void bwUpload_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.AddToProgress(Convert.ToString(e.UserState),
                e.ProgressPercentage == 0 ? Color.Red : e.ProgressPercentage == 100 ? Color.Green : Color.Black);
        }

        void bwUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.AddToProgress("User cancelled upload", Color.OrangeRed, true);
            }
            else if (e.Error != null)
            {
                this.AddToProgress(String.Format("An error occurred: {0}", e.Error.Message), Color.Red, true);
            }
            else
            {
                if (this._completedUploadCount == 0)
                {
                    this.AddToProgress("There were no files to upload. No work was done.", Color.Red, true);
                }
                else if (this._completedUploadCount == this._failedUploadCount)
                {
                    this.AddToProgress("Operation complete. All files failed to upload. No work was done.",
                        Color.Red,
                        true);
                }
                else if (this._failedUploadCount > 0)
                {
                    this.AddToProgress(string.Format("Operation complete. {0} files were successfully uploaded and {1} files failed to upload.",
                            (this._completedUploadCount - this._failedUploadCount).ToString(),
                            this._failedUploadCount.ToString()),
                        Color.OrangeRed,
                        true);
                }
                else
                {
                    this.AddToProgress("Operation Complete. All " + this._completedUploadCount.ToString() + " files were uploaded successfully",
                        Color.Green,
                        true);
                }
            }
            this.llCancel.Visible = false;
        }

        private void UploadAllFilesInFolderToFtp(string folderPath, BackgroundWorker bg, DoWorkEventArgs e)
        {
            if (bg.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            foreach (string file in Directory.GetFiles(folderPath))
            {
                bwUpload.ReportProgress(50, "Uploading " + file);                
                string fileName = file.Substring(this.txtFiles.Text.Length + 1);
                try
                {
                    FileStream localFileStream = File.OpenRead(file);
                    Stream ftpFileStream = GetFtpFileStream(fileName,
                        this.txtFTP.Text.Trim(),
                        this.txtFTPUserName.Text.Trim(),
                        this.txtFTPPassword.Text.Trim(),
                        bg,
                        e);
                    WriteLocalFileIntoFTPFile(localFileStream, ftpFileStream, bg, e);
                    bwUpload.ReportProgress(100, "Uploaded file successfully");
                }
                catch (Exception ex)
                {
                    bwUpload.ReportProgress(0, "Upload failed - " + ex.Message);
                    this._failedUploadCount++;
                }
                this._completedUploadCount++;
            }
            foreach (string folder in Directory.GetDirectories(folderPath))
            {
                UploadAllFilesInFolderToFtp(folder, bg, e);
            }
        }

        private static Stream GetFtpFileStream(string fileName, string URI, string userName, string password, BackgroundWorker bg, DoWorkEventArgs e)
        {
            if (bg.CancellationPending)
            {
                e.Cancel = true;
                return null;
            }
            Stream ftpFileStream = null;
            try
            {
                FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URI + fileName);
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;                
                ftpRequest.Credentials = new NetworkCredential(userName, password);
                ftpRequest.Timeout = 60000;
                ftpFileStream = ftpRequest.GetRequestStream();
            }
            catch (WebException ex) //folder does not exists on FTP server.
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    string folderName = fileName.Remove(fileName.LastIndexOf('\\'));
                    FtpWebRequest ftpCreateFileRequest = (FtpWebRequest)WebRequest.Create(URI + folderName);
                    ftpCreateFileRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                    ftpCreateFileRequest.KeepAlive = false;
                    ftpCreateFileRequest.Timeout = 15000;
                    ftpCreateFileRequest.Credentials = new NetworkCredential(userName, password);
                    FtpWebResponse fwr = (FtpWebResponse)ftpCreateFileRequest.GetResponse();
                    string status = fwr.StatusDescription;
                    fwr.Close();
                    FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(URI + fileName);
                    ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                    ftpRequest.Credentials = new NetworkCredential(userName, password);
                    ftpRequest.Timeout = 600000;
                    ftpFileStream = ftpRequest.GetRequestStream();
                }
                else
                {
                    throw ex;
                }
            }
            return ftpFileStream;
        }

        private static void WriteLocalFileIntoFTPFile(FileStream localFileStream, Stream ftpFileStream, BackgroundWorker bg, DoWorkEventArgs e)
        {
            if (bg.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            int length = 1024;
            byte[] buffer = new byte[length];
            int bytesRead = 0;

            do
            {
                bytesRead = localFileStream.Read(buffer, 0, length);
                ftpFileStream.Write(buffer, 0, bytesRead);
            } while (bytesRead != 0);

            ftpFileStream.Flush();
            ftpFileStream.Close();
            localFileStream.Close();
        }

        private void AddToProgress(string text, Color color, bool bold = false)
        {
            this.rtbProgress.SelectionColor = color;
            if (bold)
            {
                this.rtbProgress.SelectionFont = new Font(this.rtbProgress.Font, FontStyle.Bold);
                this.rtbProgress.SelectionIndent = 0;
            }
            else
            {
                this.rtbProgress.SelectionIndent = (color == Color.Red || color == Color.Green ? 20 : 0);
            }
            this.rtbProgress.SelectedText = text + Environment.NewLine;
            this.rtbProgress.ScrollToCaret();
        }
    }
}