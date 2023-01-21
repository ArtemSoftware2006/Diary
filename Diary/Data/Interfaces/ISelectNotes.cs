using Diary.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    internal interface ISelectNotes
    {
        DataSet Select(INoteSpecification spec, Note note);
    }
}
