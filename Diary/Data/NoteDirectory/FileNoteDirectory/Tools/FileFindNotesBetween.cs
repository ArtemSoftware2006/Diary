using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Directory
{
    public class FileFindNotesBetween : IFindNote
    {
        public int StartNumber { get; set; }
        public int StopNumber { get; set; }
        public string FilePath { get; set; }
        public FileFindNotesBetween(int startNumber, int stopNumber, string path)
        {
            this.StartNumber = startNumber;
            this.StopNumber = stopNumber;
            this.FilePath = path;
        }

        public bool Find()
        {
            int count = int.Parse(File.ReadAllText(FilePath).Split(new char[] { '*' })[0]);

            return (StartNumber < count) && (StopNumber > count);
        }
    }
}
