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
    public class NotePath : Path
    {

        public override void CreateNewPath()
        {
            CurrentPath = CurrentDirectory + "/Note" +Settings.Default.CounterNotes.ToString() + ".txt";
        }
        public override void CreateDirectory()
        {
            CurrentDirectory = Application.StartupPath + "//Notes";
        }
    }
}
