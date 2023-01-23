using Diary.Data.Entity;
using Diary.Data.Interfaces;
using System.Collections.Generic;

namespace Diary.Data.NoteDirectory
{
    abstract public class AbstractNoteProperty
    {
        abstract public bool Find(IFindNote condition);
        abstract public List<Note> Select(ISelectNote condition);
        abstract public void Create(Note note);
        abstract public void Delete(Note note);
        abstract public void Update(Note note);
    }
}
