
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
            this.FolderToWatchLbl = new System.Windows.Forms.Label();
            this.WatchFolderTxtBox = new System.Windows.Forms.TextBox();
            this.FTWBrowseBtn = new System.Windows.Forms.Button();
            this.StatusDisplayBar = new System.Windows.Forms.StatusStrip();
            this.StatusDisplayText = new System.Windows.Forms.ToolStripStatusLabel();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.Background.SuspendLayout();
            this.StatusDisplayBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
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
            this.Background.Size = new System.Drawing.Size(788, 465);
            this.Background.TabIndex = 0;
            // 
            // FolderToWatchLbl
            // 
            this.FolderToWatchLbl.AutoSize = true;
            this.FolderToWatchLbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderToWatchLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FolderToWatchLbl.Location = new System.Drawing.Point(30, 146);
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
            this.WatchFolderTxtBox.Location = new System.Drawing.Point(175, 146);
            this.WatchFolderTxtBox.Name = "WatchFolderTxtBox";
            this.WatchFolderTxtBox.Size = new System.Drawing.Size(260, 22);
            this.WatchFolderTxtBox.TabIndex = 3;
            this.WatchFolderTxtBox.Text = "test";
            this.WatchFolderTxtBox.TextChanged += new System.EventHandler(this.FTWTxt_Changed);
            // 
            // FTWBrowseBtn
            // 
            this.FTWBrowseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(255)))));
            this.FTWBrowseBtn.FlatAppearance.BorderSize = 2;
            this.FTWBrowseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FTWBrowseBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FTWBrowseBtn.ForeColor = System.Drawing.Color.Black;
            this.FTWBrowseBtn.Location = new System.Drawing.Point(453, 142);
            this.FTWBrowseBtn.Name = "FTWBrowseBtn";
            this.FTWBrowseBtn.Size = new System.Drawing.Size(67, 26);
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
            this.StatusDisplayBar.Location = new System.Drawing.Point(0, 439);
            this.StatusDisplayBar.Name = "StatusDisplayBar";
            this.StatusDisplayBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusDisplayBar.Size = new System.Drawing.Size(788, 26);
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
            this.UpPanel.Size = new System.Drawing.Size(788, 100);
            this.UpPanel.TabIndex = 0;
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Gray;
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.ForeColor = System.Drawing.Color.White;
            this.StartBtn.Location = new System.Drawing.Point(34, 366);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(121, 41);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseMnemonic = false;
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.Color.Gray;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StopBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.ForeColor = System.Drawing.Color.White;
            this.StopBtn.Location = new System.Drawing.Point(262, 366);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(121, 41);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseMnemonic = false;
            this.StopBtn.UseVisualStyleBackColor = false;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
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
            this.ClientSize = new System.Drawing.Size(788, 465);
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
    }
}

