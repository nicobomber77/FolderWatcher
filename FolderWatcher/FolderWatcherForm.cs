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
            //OpenFileDialog opf = new OpenFileDialog() { Filter = "Folders"};

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





        private string[] ParseCSV(string extensions)
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
            ListViewItem item = new ListViewItem(FileTypeTxt.Text);
            FileList.Items.Add(item);
            item.SubItems.Add("");
            item.SubItems.Add("");
            FileTypeTxt.Text = "";
        }







        private void ExtensionTxt_TextChanged(object sender, EventArgs e)
        {
            Char[] TxtToChar = ExtensionTxt.Text.ToCharArray();

            if ( TxtToChar[0] != '.' )
            {
                StatusDisplayText.Text = "Insert a dot before the extension!";
               
               ExtensionTxt.Text = " ";
            }

            else StatusDisplayText.Text = "";
        }

        private void ExtensionAddBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if(FileList.SelectedItems.Count > 0) item = FileList.SelectedItems[0];
            else
            {
                StatusDisplayText.Text = "Select something";
                return;
            }


            if (item.SubItems[1].Text == "" )
            {
                item.SubItems[1].Text = ExtensionTxt.Text;

            }
            else
            {
                string subitem = item.SubItems[1].Text + " | " + ExtensionTxt.Text;
                item.SubItems[1].Text = subitem;
            }
           

        }





       

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            FileList.SelectedItems[0].Remove();
        }

        private void FldPathBrowseBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //OpenFileDialog opf = new OpenFileDialog() { Filter = "Folders"};

            if ( fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
                PathTxt.Text = fbd.SelectedPath;
        }



        private void PathAddBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if ( FileList.SelectedItems.Count > 0 ) item = FileList.SelectedItems[0];
            else 
            { 
                StatusDisplayText.Text = "Select something";
                return;
            }

            if ( Directory.Exists(PathTxt.Text) )
            {
                item.SubItems[1].Text = PathTxt.Text;
                PathTxt.Clear();
            }
            else
            {
                StatusDisplayText.Text = "Invalid Path";
            }
               
        }

        private void RemoveExtBtn_Click(object sender, EventArgs e)
        {
            ListViewItem item;
            if ( FileList.SelectedItems.Count > 0 ) item = FileList.SelectedItems[0];
            else
            {
                StatusDisplayText.Text = "Select something";
                return;
            }


            string[] SplitExt = item.SubItems[1].Text.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            for ( int i = 0; i < SplitExt.Length; i++ )
            {
                item.SubItems[1].Text = "";
                if ( SplitExt[i] != ExtensionTxt.Text )
                {
                    item.SubItems[1].Text = "";
                    item.SubItems[1].Text += SplitExt[i];
                    Console.WriteLine("Got a Match!");
                }

            }


        }
    }
}
