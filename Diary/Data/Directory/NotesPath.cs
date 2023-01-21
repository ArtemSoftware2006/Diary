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
    public class NotesPath : Path
    {
        public override void CreatePath()
        {
            CurrentPath = Application.StartupPath + "//Note" + Settings.Default.CounterNotes.ToString();
        }
    }
}
