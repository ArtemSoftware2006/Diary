using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.SQL;

namespace Diary.Data.Directory
{
    public class FileNoteSaving : NotesRepozitory
    { 
        
        public override void CreateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Date.ToString() + Environment.NewLine);
            File.WriteAllText(note.PathNote.CurrentPath, note.Text);
        }

        public override void DeleteNote(Note note)
        {
            File.Delete(note.PathNote.CurrentPath);
        }

        public override void UpdateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Date + Environment.NewLine + note.Text);
        }

        public override Note ReadNote(Services.Path note)
        {
            throw new NotImplementedException();
        }

        public override bool Find(IFindNote condition)
        {
            throw new NotImplementedException();
        }

        public override List<Note> Select(ISelectNote condition)
        {
            throw new NotImplementedException();
        }
    }
}
