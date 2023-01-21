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
    public class FileNoteSaving : INotesRepozitory , IFindNote , ISelectNode
    {
        public void CreateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Date.ToString() + Environment.NewLine);
            File.WriteAllText(note.PathNote.CurrentPath, note.Text);
        }

        public void DeleteNote(Note note)
        {
            File.Delete(note.PathNote.CurrentPath);
        }

        public Note ReadNote(Note note)
        {
            Note tmp = new Note();

            tmp.Date = new MySqlDateTime() { Date = File.ReadLines(note.PathNote.CurrentPath).First() };
            tmp.Text =  String.Join(",",File.ReadAllText(note.PathNote.CurrentPath).Skip(1));

            return tmp;
        }

        public bool Find(INoteSpecification specific, Note note)
        {
            return specific.Quary(note);
        }

        public void UpdateNote(Note note)
        {
            File.WriteAllText(note.PathNote.CurrentPath, note.Date + Environment.NewLine + note.Text);
        }

        public Note Select(INoteSpecification spec, Note note)
        {
            return spec.Quary(note);
        }
    }
}
