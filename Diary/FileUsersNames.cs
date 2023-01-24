using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    static public class FileUsersNames
    {
        static public string DirectoryName { get; set; }
        static public string FileName { get; set; }
        static public string CreatePathFileText(string concreteName)
        {
            return FileName + concreteName;
        }

        static public string CreatePathDirectoryName(string concreteName)
        {
            return DirectoryName + concreteName;
        }
    }
}
