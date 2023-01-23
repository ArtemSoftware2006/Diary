using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.Services;
using Diary.SQL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Directory
{
    public class SelectNoteByID : ISelectNote
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public Note Note { get; set; }
        public List<Note> ListNotes { get; set; }

        public SelectNoteByID(string path,int id)
        {
            ListNotes = new List<Note>();
            this.Id = id;
            this.Path = path;
            this.Note = new Note();
        }

        public List<Note> Select()
        {
            string[] text = File.ReadAllText(Path).Split(new char[] { '*' });

            if ( Convert.ToInt32(text[0]) == Id)
            {
                Note.Id = Convert.ToInt32(text[0]);
                Note.PathNote = text[1];
                Note.Date = new MySqlDateTime(text[2]);
                Note.UserId = Convert.ToInt32(text[3]);

                ListNotes.Add(Note);

                return ListNotes;
            }
            else
            {
                ListNotes.Clear();

            }

            return ListNotes;
        }
    }
}
