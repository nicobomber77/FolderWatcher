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
            if(info.)
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
    }
}
