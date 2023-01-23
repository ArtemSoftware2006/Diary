using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.Notes;
using Diary.SQL;

namespace Diary.Data.Directory
{
    public class FileNoteSaving : NotesRepozitory
    { 
        public override void CreateNote(Note note)
        {
            File.WriteAllText(note.PathNote.PathFile, note.Date.ToString() + Environment.NewLine);
            File.WriteAllText(note.PathNote.PathFile, note.Text);
        }

        public override void DeleteNote(Note note)
        {
            File.Delete(note.PathNote.PathFile);
        }

        public override void UpdateNote(Note note)
        {
            File.WriteAllText(note.PathNote.PathFile, note.Date + Environment.NewLine + note.Text);
        }
        public override bool Find(IFindNote condition)
        {
            return condition.Find();
        }

        public override List<Note> Select(ISelectNote condition)
        {
            return condition.Select();
        }
    }
}
