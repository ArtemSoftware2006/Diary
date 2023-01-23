using Diary.Data.Entity;
using Diary.Data.Interfaces;
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
        public Note CurrentNote { get; set; }
        public FileFindNotesBetween(int startNumber, int stopNumber, Note note)
        {
            this.StartNumber = startNumber;
            this.StopNumber = stopNumber;
            this.CurrentNote = note;
        }

        public bool Find()
        {
            int count = int.Parse(Path.GetFileNameWithoutExtension(CurrentNote.PathNote).ToString().Substring(4));
            return (StartNumber < count) && (StopNumber > count);
        }
    }
}
