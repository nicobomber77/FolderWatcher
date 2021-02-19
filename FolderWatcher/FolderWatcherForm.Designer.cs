
namespace FolderWatcher
{
    partial class FolderWatcherForm
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
            if ( disposing && (components != null) )
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
            this.Background = new System.Windows.Forms.Panel();
            this.PathAddBtn = new System.Windows.Forms.Button();
            this.PathLbl = new System.Windows.Forms.Label();
            this.PathTxt = new System.Windows.Forms.TextBox();
            this.ExtensionAddBtn = new System.Windows.Forms.Button();
            this.FileTypeAddBtn = new System.Windows.Forms.Button();
            this.ExtensionLbl = new System.Windows.Forms.Label();
            this.ExtensionTxt = new System.Windows.Forms.TextBox();
            this.FileTypeLbl = new System.Windows.Forms.Label();
            this.FileTypeTxt = new System.Windows.Forms.TextBox();
            this.FileList = new System.Windows.Forms.ListView();
            this.Filetype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extensions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StopBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FolderToWatchLbl = new System.Windows.Forms.Label();
            this.WatchFolderTxtBox = new System.Windows.Forms.TextBox();
            this.FTWBrowseBtn = new System.Windows.Forms.Button();
            this.StatusDisplayBar = new System.Windows.Forms.StatusStrip();
            this.StatusDisplayText = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.Background.SuspendLayout();
            this.StatusDisplayBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.Background.Controls.Add(this.PathAddBtn);
            this.Background.Controls.Add(this.PathLbl);
            this.Background.Controls.Add(this.PathTxt);
            this.Background.Controls.Add(this.ExtensionAddBtn);
            this.Background.Controls.Add(this.FileTypeAddBtn);
            this.Background.Controls.Add(this.ExtensionLbl);
            this.Background.Controls.Add(this.ExtensionTxt);
            this.Background.Controls.Add(this.FileTypeLbl);
            this.Background.Controls.Add(this.FileTypeTxt);
            this.Background.Controls.Add(this.FileList);
            this.Background.Controls.Add(this.StopBtn);
            this.Background.Controls.Add(this.StartBtn);
            this.Background.Controls.Add(this.FolderToWatchLbl);
            this.Background.Controls.Add(this.WatchFolderTxtBox);
            this.Background.Controls.Add(this.FTWBrowseBtn);
            this.Background.Controls.Add(this.StatusDisplayBar);
            this.Background.Controls.Add(this.UpPanel);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(770, 459);
            this.Background.TabIndex = 0;
            // 
            // PathAddBtn
            // 
            this.PathAddBtn.BackColor = System.Drawing.Color.DimGray;
            this.PathAddBtn.FlatAppearance.BorderSize = 0;
            this.PathAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PathAddBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathAddBtn.ForeColor = System.Drawing.Color.White;
            this.PathAddBtn.Location = new System.Drawing.Point(389, 331);
            this.PathAddBtn.Name = "PathAddBtn";
            this.PathAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PathAddBtn.TabIndex = 16;
            this.PathAddBtn.Text = "Add";
            this.PathAddBtn.UseVisualStyleBackColor = false;
            this.PathAddBtn.Click += new System.EventHandler(this.PathAddBtn_Click);
            // 
            // PathLbl
            // 
            this.PathLbl.AutoSize = true;
            this.PathLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PathLbl.Location = new System.Drawing.Point(395, 286);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(36, 16);
            this.PathLbl.TabIndex = 15;
            this.PathLbl.Text = "Path";
            // 
            // PathTxt
            // 
            this.PathTxt.BackColor = System.Drawing.Color.DimGray;
            this.PathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTxt.Location = new System.Drawing.Point(389, 305);
            this.PathTxt.Name = "PathTxt";
            this.PathTxt.Size = new System.Drawing.Size(274, 20);
            this.PathTxt.TabIndex = 14;
            this.PathTxt.TextChanged += new System.EventHandler(this.PathTxt_TextChanged);
            // 
            // ExtensionAddBtn
            // 
            this.ExtensionAddBtn.BackColor = System.Drawing.Color.DimGray;
            this.ExtensionAddBtn.FlatAppearance.BorderSize = 0;
            this.ExtensionAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtensionAddBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionAddBtn.ForeColor = System.Drawing.Color.White;
            this.ExtensionAddBtn.Location = new System.Drawing.Point(219, 331);
            this.ExtensionAddBtn.Name = "ExtensionAddBtn";
            this.ExtensionAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ExtensionAddBtn.TabIndex = 13;
            this.ExtensionAddBtn.Text = "Add";
            this.ExtensionAddBtn.UseVisualStyleBackColor = false;
            this.ExtensionAddBtn.Click += new System.EventHandler(this.ExtensionAddBtn_Click);
            // 
            // FileTypeAddBtn
            // 
            this.FileTypeAddBtn.BackColor = System.Drawing.Color.DimGray;
            this.FileTypeAddBtn.FlatAppearance.BorderSize = 0;
            this.FileTypeAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FileTypeAddBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTypeAddBtn.ForeColor = System.Drawing.Color.White;
            this.FileTypeAddBtn.Location = new System.Drawing.Point(55, 331);
            this.FileTypeAddBtn.Name = "FileTypeAddBtn";
            this.FileTypeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.FileTypeAddBtn.TabIndex = 12;
            this.FileTypeAddBtn.Text = "Add";
            this.FileTypeAddBtn.UseVisualStyleBackColor = false;
            this.FileTypeAddBtn.Click += new System.EventHandler(this.FileTypeAddBtn_Click);
            // 
            // ExtensionLbl
            // 
            this.ExtensionLbl.AutoSize = true;
            this.ExtensionLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtensionLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExtensionLbl.Location = new System.Drawing.Point(225, 286);
            this.ExtensionLbl.Name = "ExtensionLbl";
            this.ExtensionLbl.Size = new System.Drawing.Size(68, 16);
            this.ExtensionLbl.TabIndex = 11;
            this.ExtensionLbl.Text = "Extension";
            // 
            // ExtensionTxt
            // 
            this.ExtensionTxt.BackColor = System.Drawing.Color.DimGray;
            this.ExtensionTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExtensionTxt.Location = new System.Drawing.Point(219, 305);
            this.ExtensionTxt.Name = "ExtensionTxt";
            this.ExtensionTxt.Size = new System.Drawing.Size(100, 20);
            this.ExtensionTxt.TabIndex = 10;
            this.ExtensionTxt.TextChanged += new System.EventHandler(this.ExtensionTxt_TextChanged);
            // 
            // FileTypeLbl
            // 
            this.FileTypeLbl.AutoSize = true;
            this.FileTypeLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTypeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileTypeLbl.Location = new System.Drawing.Point(61, 286);
            this.FileTypeLbl.Name = "FileTypeLbl";
            this.FileTypeLbl.Size = new System.Drawing.Size(65, 16);
            this.FileTypeLbl.TabIndex = 9;
            this.FileTypeLbl.Text = "File Type";
            // 
            // FileTypeTxt
            // 
            this.FileTypeTxt.BackColor = System.Drawing.Color.DimGray;
            this.FileTypeTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileTypeTxt.Location = new System.Drawing.Point(55, 305);
            this.FileTypeTxt.Name = "FileTypeTxt";
            this.FileTypeTxt.Size = new System.Drawing.Size(100, 20);
            this.FileTypeTxt.TabIndex = 8;
            this.FileTypeTxt.TextChanged += new System.EventHandler(this.FileTypeTxt_TextChanged);
            // 
            // FileList
            // 
            this.FileList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.FileList.BackColor = System.Drawing.Color.Gray;
            this.FileList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filetype,
            this.Extensions,
            this.DestFolder});
            this.FileList.HideSelection = false;
            this.FileList.Location = new System.Drawing.Point(16, 174);
            this.FileList.MultiSelect = false;
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(728, 97);
            this.FileList.TabIndex = 7;
            this.FileList.UseCompatibleStateImageBehavior = false;
            this.FileList.View = System.Windows.Forms.View.Details;
            // 
            // Filetype
            // 
            this.Filetype.Text = "File type";
            this.Filetype.Width = 94;
            // 
            // Extensions
            // 
            this.Extensions.Text = "Extensions";
            this.Extensions.Width = 82;
            // 
            // DestFolder
            // 
            this.DestFolder.Text = "Destination folder";
            this.DestFolder.Width = 558;
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Gray;
            this.StopBtn.FlatAppearance.BorderSize = 0;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.Color.White;
            this.StopBtn.Location = new System.Drawing.Point(637, 380);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(121, 41);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseMnemonic = false;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Gray;
            this.StartBtn.FlatAppearance.BorderSize = 0;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(496, 380);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(121, 41);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseMnemonic = false;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FolderToWatchLbl
            // 
            this.FolderToWatchLbl.AutoSize = true;
            this.FolderToWatchLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderToWatchLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FolderToWatchLbl.Location = new System.Drawing.Point(12, 113);
            this.FolderToWatchLbl.Name = "FolderToWatchLbl";
            this.FolderToWatchLbl.Size = new System.Drawing.Size(125, 20);
            this.FolderToWatchLbl.TabIndex = 4;
            this.FolderToWatchLbl.Text = "Folder to watch";
            // 
            // WatchFolderTxtBox
            // 
            this.WatchFolderTxtBox.BackColor = System.Drawing.Color.DimGray;
            this.WatchFolderTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WatchFolderTxtBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatchFolderTxtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.WatchFolderTxtBox.Location = new System.Drawing.Point(157, 113);
            this.WatchFolderTxtBox.Name = "WatchFolderTxtBox";
            this.WatchFolderTxtBox.Size = new System.Drawing.Size(260, 22);
            this.WatchFolderTxtBox.TabIndex = 3;
            this.WatchFolderTxtBox.Text = "test";
            this.WatchFolderTxtBox.TextChanged += new System.EventHandler(this.FTWTxt_Changed);
            // 
            // FTWBrowseBtn
            // 
            this.FTWBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.FTWBrowseBtn.FlatAppearance.BorderSize = 0;
            this.FTWBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FTWBrowseBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTWBrowseBtn.ForeColor = System.Drawing.Color.White;
            this.FTWBrowseBtn.Location = new System.Drawing.Point(435, 109);
            this.FTWBrowseBtn.Name = "FTWBrowseBtn";
            this.FTWBrowseBtn.Size = new System.Drawing.Size(83, 34);
            this.FTWBrowseBtn.TabIndex = 2;
            this.FTWBrowseBtn.Text = "Browse";
            this.FTWBrowseBtn.UseVisualStyleBackColor = false;
            this.FTWBrowseBtn.Click += new System.EventHandler(this.FTWBrowseBtn_Click);
            // 
            // StatusDisplayBar
            // 
            this.StatusDisplayBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.StatusDisplayBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusDisplayText});
            this.StatusDisplayBar.Location = new System.Drawing.Point(0, 433);
            this.StatusDisplayBar.Name = "StatusDisplayBar";
            this.StatusDisplayBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusDisplayBar.Size = new System.Drawing.Size(770, 26);
            this.StatusDisplayBar.TabIndex = 1;
            this.StatusDisplayBar.Text = "Stuff Happened";
            // 
            // StatusDisplayText
            // 
            this.StatusDisplayText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
            this.StatusDisplayText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusDisplayText.Name = "StatusDisplayText";
            this.StatusDisplayText.Size = new System.Drawing.Size(134, 21);
            this.StatusDisplayText.Text = "Stuff Happened";
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(770, 100);
            this.UpPanel.TabIndex = 0;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // FolderWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 459);
            this.Controls.Add(this.Background);
            this.Name = "FolderWatcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.StatusDisplayBar.ResumeLayout(false);
            this.StatusDisplayBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.StatusStrip StatusDisplayBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusDisplayText;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Button FTWBrowseBtn;
        private System.Windows.Forms.Label FolderToWatchLbl;
        private System.Windows.Forms.TextBox WatchFolderTxtBox;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ListView FileList;
        private System.Windows.Forms.ColumnHeader Filetype;
        private System.Windows.Forms.ColumnHeader Extensions;
        private System.Windows.Forms.ColumnHeader DestFolder;
        private System.Windows.Forms.Button PathAddBtn;
        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.TextBox PathTxt;
        private System.Windows.Forms.Button ExtensionAddBtn;
        private System.Windows.Forms.Button FileTypeAddBtn;
        private System.Windows.Forms.Label ExtensionLbl;
        private System.Windows.Forms.TextBox ExtensionTxt;
        private System.Windows.Forms.Label FileTypeLbl;
        private System.Windows.Forms.TextBox FileTypeTxt;
    }
}

