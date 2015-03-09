using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GetModifiedFiles
{
    public partial class Form1 : Form
    {
        private List<string> _fileList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            frmUpload f = new frmUpload();
            f.txtFiles.Text = this.txtFiles.Text;
            f.Show(this);
        }

        private void btnBrowseSearch_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.Description = "Choose a folder to search.";
            this.folderBrowserDialog1.SelectedPath = Properties.Settings.Default.SearchFolder;
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtSearch.Text = this.folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.SearchFolder = this.folderBrowserDialog1.SelectedPath;
            }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.compute.co.il");
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            var delimiter = new char[] { ';' };
            try
            {
                this.Cursor = Cursors.AppStarting;
                DirectoryInfo di = new DirectoryInfo(this.txtFiles.Text.Trim());
                if (!this.FillFileList())
                {
                    return;
                }
                if (!di.Exists)
                {
                    try
                    {
                        di.Create();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Could not create the folder: \"" + di.FullName + "\"\n" + ex.Message,
                            "Get Modified Files",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (di.GetDirectories().Length > 0 || di.GetFiles().Length > 0)
                {
                    if (MessageBox.Show("The folder has files in it. To continue all files must be deleted. Do you wish to continue?",
                        "Get Modified Files - Create Folder",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        di.Delete(true);
                        di.Create();
                    }
                    else
                    {
                        return;
                    }
                }                
                foreach (string file in _fileList)
                {
                    bool isExcluded = false;
                    foreach (string excluded in this.txtFilestoIgnore.Text.Trim().Split(delimiter,StringSplitOptions.RemoveEmptyEntries))
                    {
                        if (file.Contains(excluded))
                        {
                            isExcluded = true;
                            break;
                        }
                    }
                    if (!isExcluded)
                    {
                        foreach (string extension in this.txtFileExtensions.Text.Trim().Split(delimiter, StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (Path.GetExtension(file) == (extension.Trim().StartsWith(".") ?
                                extension.Trim() : "." + extension.Trim()))
                            {
                                isExcluded = true;
                                break;
                            }
                        }
                    }
                    if (!isExcluded)
                    {
                        string[] foldersInFilePath = file.Split(new char[] { '\\' });
                        foreach (string excludedFolder in this.txtFoldersToIgnore.Text.Trim().Split(delimiter, StringSplitOptions.RemoveEmptyEntries))
                        {
                            foreach (string folderName in foldersInFilePath)
                            {
                                if (isExcluded) break;
                                if (folderName == excludedFolder)
                                {
                                    isExcluded = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (isExcluded)
                    {
                        continue;
                    }

                    string[] fileParts = file.Split(new char[] { '\\' });
                    fileParts[fileParts.Length - 1] = "";
                    string fileDirectory = string.Join("\\", fileParts);

                    if (!Directory.Exists(di.FullName + "\\" + fileDirectory))
                    {
                        Directory.CreateDirectory(di.FullName + "\\" + fileDirectory);
                    }
                    File.Copy(this.txtSearch.Text + "\\" + file, di.FullName + "\\" + file);
                }
                System.Diagnostics.Process.Start(di.FullName);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Woops! something went wrong while creating the folder: \"" + this.txtFiles.Text.Trim() + "\"\n" + exc.Message, "Get Modified Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Cursor = Cursors.Default;
        }

        private bool FillFileList()
        {
            if (!Directory.Exists(this.txtSearch.Text))
            {
                GetFolder();
            }
            if (!Directory.Exists(this.txtSearch.Text))
            {
                MessageBox.Show("Search folder could not be found", "Get Modified Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            this._fileList.Clear();
            foreach (string file in Directory.GetFiles(this.txtSearch.Text, "*.*", SearchOption.AllDirectories))
            {
                if (File.GetCreationTime(file) >= mcFromDate.SelectionStart || File.GetLastWriteTime(file) >= mcFromDate.SelectionStart)
                {
                    this._fileList.Add(file.Remove(0, this.txtSearch.Text.Length + 1));
                }
            }
            if (this._fileList.Count == 0)
            {
                MessageBox.Show("There are no modified files to copy.", "Get Modified Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GetFolder()
        {
            if (!Directory.Exists(this.txtSearch.Text))
            {
                this.btnBrowseSearch_Click(null, null);
            }
        }
    }
}