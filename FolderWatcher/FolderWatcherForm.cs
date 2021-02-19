using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderWatcher
{
    public partial class FolderWatcherForm : Form
    {
        public FolderWatcherForm()
        {
            InitializeComponent();
        }

        public const string EXTENSIONS = "Extensions";
        public const string FILETYPE = "FileType";
        public const string FILEDIR = "FileDest";

        private void FTWBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if ( fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                WatchFolderTxtBox.Text = fbd.SelectedPath;
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = true;

            
            

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            fileSystemWatcher.EnableRaisingEvents = false;
        }


        #region FileSystemWatcher

        private void fileSystemWatcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            StatusDisplayText.Text = $"File: {e.Name} was modified.";
        }

        private void fileSystemWatcher_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            StatusDisplayText.Text = $"File: {e.Name} was created.";

            var info = new FileInfo(e.FullPath);
            //if(info.)
        }

        private void fileSystemWatcher_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            StatusDisplayText.Text = $"File: {e.Name} was deleted.";
        }

        private void fileSystemWatcher_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            StatusDisplayText.Text = $"File: {e.Name} was renamed.";
        }


        #endregion

        private void FTWTxt_Changed(object sender, EventArgs e)
        {
            fileSystemWatcher.Path = WatchFolderTxtBox.Text;
        }





        private string[] ParseExt(string extensions)
        {

            string[] SplitExt = extensions.Split(';');

            for ( int i = 0; i < SplitExt.Length; i++ )
            {

                SplitExt[i] = SplitExt[i].Replace(" ", "");
            }

            return SplitExt;
        }





        private void FileTypeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileTypeAddBtn_Click(object sender, EventArgs e)
        {
            FileList.Items.Add(FileTypeTxt.Text);
            FileTypeTxt.Text = "";
        }







        private void ExtensionTxt_TextChanged(object sender, EventArgs e)
        {
            Char[] TxtToChar = ExtensionTxt.Text.ToCharArray();

            if (TxtToChar[0] != '.' ) StatusDisplayText.Text = "Insert a dot before the extension!";
            
            else StatusDisplayText.Text = "";
        }

        private void ExtensionAddBtn_Click(object sender, EventArgs e)
        {
          // FileList.SelectedItems[0].SubItems[1].Text += ExtensionTxt.Text;

            StatusDisplayText.Text = FileList.SelectedItems[0].SubItems.Count.ToString();
        }





        private void PathTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PathAddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
