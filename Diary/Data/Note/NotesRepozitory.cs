using Diary.Data.Entity;
using Diary.Data.Notes;
using Diary.Data.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    public abstract class NotesRepozitory
    {
        protected IFindNote findNote;
        protected ISelectNote selectNote;
        abstract public void CreateNote(Note note);
        abstract public void DeleteNote(Note note);
        abstract public void UpdateNote(Note note);
        abstract public Note ReadNote(NotePath path);
        abstract public bool Find(IFindNote condition,Note note);
        abstract public List<Note> Select(ISelectNote condition, Note note);
    }
}
