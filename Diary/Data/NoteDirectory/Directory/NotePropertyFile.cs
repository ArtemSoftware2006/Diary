using Diary.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.NoteDirectory.Directory.Tools
{
    public class NotePropertyFile : AbstractNoteProperty
    {
        public override void Delete(Note note)
        {
            File.Delete(note.PathNote.PathFile);
        }

        public override void Save(Note note)
        {
            File.WriteAllText(note.PathNote.PathFile,note.Id.ToString() + " " + note.PathNote.PathFile + " " 
                + note.Date.Date.ToString() + " " + note.UserId.ToString());
        }

        public override void Update(Note note)
        {
            File.WriteAllText(note.PathNote.PathFile, note.Id.ToString() + " " + note.PathNote.PathFile + " "
                + note.Date.Date.ToString() + " " + note.UserId.ToString());
        }
    }
}
