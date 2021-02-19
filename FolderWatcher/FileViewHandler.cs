using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderWatcher
{
    class FileViewHandler
    {


        public void AddItem(ListView LW, string ItemName)
        {
            LW.Items.Add(ItemName);
        }


        public void AddPropriety(ListView LW)
        {
            LW.Columns.Add("");
        }


    }
}
