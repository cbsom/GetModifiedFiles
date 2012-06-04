namespace GetModifiedFiles
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewFiles = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtFilestoIgnore = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFoldersToIgnore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowseSearch = new System.Windows.Forms.Button();
            this.btnBrowseFiles = new System.Windows.Forms.Button();
            this.mcFromDate = new System.Windows.Forms.MonthCalendar();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.GhostWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnViewFiles);
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.txtFilestoIgnore);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtFoldersToIgnore);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnBrowseSearch);
            this.panel1.Controls.Add(this.btnBrowseFiles);
            this.panel1.Controls.Add(this.mcFromDate);
            this.panel1.Controls.Add(this.txtFiles);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnCreateFolder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.SlateGray;
            this.panel1.Location = new System.Drawing.Point(21, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 410);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GetModifiedFiles.Properties.Resources.Compute_Logo_Blueish_Small;
            this.pictureBox1.Location = new System.Drawing.Point(579, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnViewFiles
            // 
            this.btnViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewFiles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnViewFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewFiles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnViewFiles.Image = global::GetModifiedFiles.Properties.Resources.folder_search;
            this.btnViewFiles.Location = new System.Drawing.Point(377, 319);
            this.btnViewFiles.Name = "btnViewFiles";
            this.btnViewFiles.Size = new System.Drawing.Size(115, 70);
            this.btnViewFiles.TabIndex = 52;
            this.btnViewFiles.Text = "View Files";
            this.btnViewFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnViewFiles.UseVisualStyleBackColor = false;
            this.btnViewFiles.Click += new System.EventHandler(this.btnViewFiles_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpload.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUpload.Image = global::GetModifiedFiles.Properties.Resources.computer_network;
            this.btnUpload.Location = new System.Drawing.Point(508, 319);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(115, 70);
            this.btnUpload.TabIndex = 51;
            this.btnUpload.Text = "Upload Files";
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtFilestoIgnore
            // 
            this.txtFilestoIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilestoIgnore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilestoIgnore.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "ExcludeFiles", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFilestoIgnore.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilestoIgnore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFilestoIgnore.Location = new System.Drawing.Point(267, 211);
            this.txtFilestoIgnore.Name = "txtFilestoIgnore";
            this.txtFilestoIgnore.Size = new System.Drawing.Size(525, 23);
            this.txtFilestoIgnore.TabIndex = 50;
            this.txtFilestoIgnore.Text = global::GetModifiedFiles.Properties.Settings.Default.ExcludeFiles;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(264, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(471, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Ignore all files that contain any of the following strings in the file-name: (sem" +
    "i-colon delimited list)";
            // 
            // txtFoldersToIgnore
            // 
            this.txtFoldersToIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoldersToIgnore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoldersToIgnore.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "ExcludeFolders", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFoldersToIgnore.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoldersToIgnore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFoldersToIgnore.Location = new System.Drawing.Point(267, 149);
            this.txtFoldersToIgnore.Name = "txtFoldersToIgnore";
            this.txtFoldersToIgnore.Size = new System.Drawing.Size(525, 23);
            this.txtFoldersToIgnore.TabIndex = 48;
            this.txtFoldersToIgnore.Text = global::GetModifiedFiles.Properties.Settings.Default.ExcludeFolders;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(264, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Folders to ignore (semi-colon delimited list)";
            // 
            // btnBrowseSearch
            // 
            this.btnBrowseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseSearch.Image")));
            this.btnBrowseSearch.Location = new System.Drawing.Point(764, 37);
            this.btnBrowseSearch.Name = "btnBrowseSearch";
            this.btnBrowseSearch.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseSearch.TabIndex = 46;
            this.btnBrowseSearch.UseVisualStyleBackColor = true;
            this.btnBrowseSearch.Click += new System.EventHandler(this.btnBrowseSearch_Click);
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFiles.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseFiles.Image")));
            this.btnBrowseFiles.Location = new System.Drawing.Point(764, 89);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(28, 23);
            this.btnBrowseFiles.TabIndex = 45;
            this.btnBrowseFiles.UseVisualStyleBackColor = true;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // mcFromDate
            // 
            this.mcFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mcFromDate.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcFromDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.mcFromDate.Location = new System.Drawing.Point(25, 149);
            this.mcFromDate.Name = "mcFromDate";
            this.mcFromDate.TabIndex = 38;
            // 
            // txtFiles
            // 
            this.txtFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiles.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "CopyToFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtFiles.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiles.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtFiles.Location = new System.Drawing.Point(25, 89);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(739, 23);
            this.txtFiles.TabIndex = 44;
            this.txtFiles.Text = global::GetModifiedFiles.Properties.Settings.Default.CopyToFolder;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search for files modified after...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Folder to save copy of modified files in";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GetModifiedFiles.Properties.Settings.Default, "SearchFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSearch.Location = new System.Drawing.Point(25, 37);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(739, 23);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.Text = global::GetModifiedFiles.Properties.Settings.Default.SearchFolder;
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFolder.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreateFolder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFolder.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCreateFolder.Image = global::GetModifiedFiles.Properties.Resources.folder_add;
            this.btnCreateFolder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateFolder.Location = new System.Drawing.Point(642, 291);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(150, 98);
            this.btnCreateFolder.TabIndex = 40;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCreateFolder.UseVisualStyleBackColor = false;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Folder to search for modified files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Get Modified Files";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(825, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 8);
            this.label6.TabIndex = 17;
            this.label6.Text = "בס\"ד";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(848, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Modified Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewFiles;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtFilestoIgnore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFoldersToIgnore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowseSearch;
        private System.Windows.Forms.Button btnBrowseFiles;
        private System.Windows.Forms.MonthCalendar mcFromDate;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

