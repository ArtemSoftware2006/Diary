using Diary.Data.Entity;
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

        abstract public void CreateNote(Note note);
        abstract public void DeleteNote(Note note);
        abstract public void UpdateNote(Note note);
        abstract public Note ReadNote(Path note);
        abstract public bool Find(IFindNote condition);
        abstract public List<Note> Select(ISelectNote condition);
    }
}
