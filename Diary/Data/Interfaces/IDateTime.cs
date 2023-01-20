using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    internal interface IDateTime
    {
        string Date { get; set; }
        void ConvertDate(DateTime datetime);
    }
}
