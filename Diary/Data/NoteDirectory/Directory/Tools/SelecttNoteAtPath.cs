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
    public class SelectNoteAtPath : ISelectNote
    {
        public SelectNoteAtPath(Note note)
        {
            ListNotes = new List<Note>();
            CurrentNote = note;
        }

        public Note CurrentNote { get; set; }
        public List<Note> ListNotes { get; set; }
        public List<Note> Select()
        {
            CurrentNote.Text = File.ReadAllText(CurrentNote.PathNote.PathFile);
            ListNotes.Add(CurrentNote);

            return ListNotes;
        }
    }
}
