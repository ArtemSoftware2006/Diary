using Diary.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    internal interface INotesRepozitory
    {
        void CreateNote(Note note);
        void DeleteNote(Note note);
        void UpdateNote(Note note);
        List<DataSet> Query(INoteSpecification note);
    }
}
