using Diary.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class MySqlDateTime : IDateTime
    {
        public string Date { get ; set ; }

        public MySqlDateTime() { }
        public MySqlDateTime(string date)
        {
            Date = date;
        }

        public void ConvertDate(DateTime datetime)
        {
            Date = datetime.Year.ToString() + "-" + datetime.Month.ToString() + "-" + datetime.Day.ToString()
                           + " " + datetime.Hour.ToString() + ":" + datetime.Minute.ToString() 
                           + ":" + datetime.Second.ToString();
        }
    }
}
