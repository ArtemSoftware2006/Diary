using Diary.Data.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary.Data.User.FileUserDirectory
{
    public class PathUser : MyPath
    {
        public override void CreateNewPath(string name)
        {
            PathFile = PathDirectory + $"\\{name}.txt";
        }
        public override void CreateNewDirectory(string name)
        {
            PathDirectory = Application.StartupPath + "\\Users" + name;
            if (!System.IO.Directory.Exists(PathDirectory))
            {
                System.IO.Directory.CreateDirectory(PathDirectory);
            }
        }
    }
}
