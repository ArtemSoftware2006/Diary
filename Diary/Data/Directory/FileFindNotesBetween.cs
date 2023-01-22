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
        public int startNumber { get; set; }
        public int stopNumber { get; set; }
        public FileFindNotesBetween(int startNumber, int stopNumber)
        {
            this.startNumber = startNumber;
            this.stopNumber = stopNumber;
        }

        public bool Find(Note note)
        {
            int count = int.Parse(Path.GetFileNameWithoutExtension(note.PathNote.CurrentPath));
            return (startNumber < count) && (stopNumber > count);
        }
    }
}
