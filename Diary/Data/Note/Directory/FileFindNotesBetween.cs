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
        public FileFindNotesBetween(int startNumber, int stopNumber)
        {
            this.StartNumber = startNumber;
            this.StopNumber = stopNumber;
        }

        public bool Find(Note note)
        {
            int count = int.Parse(Path.GetFileNameWithoutExtension(note.PathNote.CurrentPath).ToString().Substring(4));
            return (StartNumber < count) && (StopNumber > count);
        }
    }
}
