namespace GetModifiedFiles
{
    partial class frmUpload
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.bwUpload = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llCancel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbProgress = new System.Windows.Forms.RichTextBox();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFTPPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFTPUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFTP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bwUpload
            // 
            this.bwUpload.WorkerReportsProgress = true;
            this.bwUpload.WorkerSupportsCancellation = true;
            this.bwUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpload_DoWork);
            this.bwUpload.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwUpload_ProgressChanged);
            this.bwUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpload_RunWorkerCompleted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(757, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 8);
            this.label2.TabIndex = 40;
            this.label2.Text = "בס\"ד";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.Controls.Add(this.llCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtbProgress);
            this.panel1.Controls.Add(this.btnBrowseFiles);
            this.panel1.Controls.Add(this.txtFiles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnViewFiles);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.txtFTPPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtFTPUserName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFTP);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(23, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 464);
            this.panel1.TabIndex = 41;
            // 
            // llCancel
            // 
            this.llCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llCancel.AutoSize = true;
            this.llCancel.Location = new System.Drawing.Point(636, 256);
            this.llCancel.Name = "llCancel";
            this.llCancel.Size = new System.Drawing.Size(75, 13);
            this.llCancel.TabIndex = 52;
            this.llCancel.TabStop = true;
            this.llCancel.Text = "Cancel Upload";
            this.llCancel.Visible = false;
            this.llCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCancel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Progress";
            // 
            // rtbProgress
            // 
            this.rtbProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbProgress.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbProgress.Location = new System.Drawing.Point(12, 272);
            this.rtbProgress.Name = "rtbProgress";
            this.rtbProgress.ReadOnly = true;
            this.rtbProgress.Size = new System.Drawing.Size(699, 176);
            this.rtbProgress.TabIndex = 50;
            this.rtbProgress.Text = "";
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseFiles.Image")));
            this.btnBrowseFiles.Location = new System.Drawing.Point(688, 53);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(23, 23);
            this.btnBrowseFiles.TabIndex = 49;
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiles.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiles.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFiles.Location = new System.Drawing.Point(22, 53);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(666, 23);
            this.txtFiles.TabIndex = 48;
            this.txtFiles.Text = "Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Name of folder to upload:";
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFiles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFiles.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnViewFiles.Image = global::GetModifiedFiles.Properties.Resources.folder_search;
            this.btnViewFiles.Location = new System.Drawing.Point(465, 167);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(115, 70);
            this.btnViewFiles.TabIndex = 46;
            this.btnViewFiles.Text = "View Files";
            this.btnViewFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUpload.Image = global::GetModifiedFiles.Properties.Resources.computer_network;
            this.btnUpload.Location = new System.Drawing.Point(596, 167);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 70);
            this.btnUpload.TabIndex = 45;
            this.btnUpload.Text = "Upload Files";
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "FtpUserPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPPassword.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFTPPassword.Location = new System.Drawing.Point(22, 214);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.PasswordChar = '*';
            this.txtFTPPassword.Size = new System.Drawing.Size(261, 23);
            this.txtFTPPassword.TabIndex = 44;
            this.txtFTPPassword.Text = global::GetModifiedFiles.Properties.Settings.Default.FtpUserPassword;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(19, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "FTP server password";
            // 
            // txtFTPUserName
            // 
            this.txtFTPUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTPUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "FtpUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTPUserName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTPUserName.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFTPUserName.Location = new System.Drawing.Point(22, 159);
            this.txtFTPUserName.Name = "txtFTPUserName";
            this.txtFTPUserName.Size = new System.Drawing.Size(258, 23);
            this.txtFTPUserName.TabIndex = 42;
            this.txtFTPUserName.Text = global::GetModifiedFiles.Properties.Settings.Default.FtpUserName;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(19, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "FTP server user name";
            // 
            // txtFTP
            // 
            this.txtFTP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "FtpURI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFTP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFTP.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtFTP.Location = new System.Drawing.Point(22, 107);
            this.txtFTP.Name = "txtFTP";
            this.txtFTP.Size = new System.Drawing.Size(689, 23);
            this.txtFTP.TabIndex = 40;
            this.txtFTP.Text = global::GetModifiedFiles.Properties.Settings.Default.FtpURI;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "FTP folder to upload to:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Upload Files - FTP";
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(777, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "frmUpload";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload To FTP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bwUpload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowseFiles;
        internal System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFTPUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbProgress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFTPPassword;
    }
}