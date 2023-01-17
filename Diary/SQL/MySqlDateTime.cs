using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class MySqlDateTime
    {
        public string StringMySqlDateTime { get; private set; }
        public MySqlDateTime(DateTime date)
        {
            StringMySqlDateTime = date.Year.ToString() + "-" + date.Month.ToString() + "-" + date.Day.ToString() 
                + " " + date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();
        }
    }
}
