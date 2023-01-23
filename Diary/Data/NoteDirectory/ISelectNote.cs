using Diary.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    public interface ISelectNote
    {
        List<Note> Select();

    }
}
