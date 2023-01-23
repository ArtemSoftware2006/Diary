using Diary.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Diary.Data.Services;
using System.IO;

namespace Diary.Data.Notes
{
    public class NotePath : MyPath
    {

        public override void CreateNewPath(string name)
        {
            PathFile = PathDirectory + $"{name}";
        }
        public override void CreateNewDirectory(string name)
        {
            PathDirectory = Application.StartupPath + $"\\Notes\\{name}\\";
            System.IO.Directory.CreateDirectory(PathDirectory);
        }

    }
}
