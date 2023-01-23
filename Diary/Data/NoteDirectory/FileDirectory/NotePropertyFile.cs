using Diary.Data.Entity;
using Diary.Data.Interfaces;
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
            File.Delete(note.PathNote);
        }

        public override bool Find(IFindNote condition)
        {
            return condition.Find();
        }

        public override void Create(Note note)
        {
            File.WriteAllText(note.PathNote,note.Id.ToString() + " " + note.PathNote + " " 
                + note.Date.Date.ToString() + " " + note.UserId.ToString());
        }

        public override List<Note> Select(ISelectNote condition)
        {
            return condition.Select();
        }

        public override void Update(Note note)
        {
            File.WriteAllText(note.PathNote, note.Id.ToString() + " " + note.PathNote + " "
                + note.Date.Date.ToString() + " " + note.UserId.ToString());
        }
    }
}
