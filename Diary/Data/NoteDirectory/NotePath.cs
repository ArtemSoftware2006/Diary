using Diary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Diary.Data.Services;

namespace Diary.Data.Notes
{
    public class NotePath : MyPath
    {

        public override void CreateNewPath()
        {
            PathFile = PathDirectory + "/Note" +Settings.Default.CounterNotes.ToString() + ".txt";
        }
        public override void CreateDirectory()
        {
            PathDirectory = Application.StartupPath + "//Notes";
        }
    }
}
