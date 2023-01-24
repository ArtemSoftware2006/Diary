using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    static public class FileNoteNames
    {
        static public string DirectoryName { get;  set; }
        static public string FileTextName { get;  set; }
        static public string FilePropertyName { get;  set; }
        static public string CreatePathFileText(string concreteName)
        {
            return FileTextName + concreteName;
        }
        static public string CreatePathFileProperty(string concreteName)
        {
            return FilePropertyName + concreteName;
        }
        static public string CreatePathDirectoryName(string concreteName)
        {
            return DirectoryName + concreteName;
        }
    }
}
