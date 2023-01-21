using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Data.Entity;
using Diary.Data.Interfaces;

namespace Diary.Data.Directory
{
    public class FileSaving : INotesRepozitory , ISelectNotes
    {
        public void CreateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Text);
        }

        public void DeleteNote(Note note)
        {
            File.Delete(note.PathNote.CurrentPath);
        }

        public string ReadNote(Note note)
        {
            return File.ReadAllText(note.PathNote.CurrentPath);
        }

        public DataSet Select(INoteSpecification specific, Note note)
        {
            return specific.Select(note);
        }

        public void UpdateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Text);
        }
    }
}
