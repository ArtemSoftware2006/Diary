using Diary.Data.Services;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.NoteDirectory
{
    abstract public class AbstractNoteText
    {
        abstract public void Create(MyPath path, string textNote);
        abstract public void Delete(MyPath pathNote);
        abstract public void Update(MyPath path,string textNote);
    }
}
