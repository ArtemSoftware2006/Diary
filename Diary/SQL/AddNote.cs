using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class AddNote : SqlCmd
    {
        private MySqlDateTime dateTime;
        public AddNote(DateTime datetime, string note, int userId) 
        {
            dateTime = new MySqlDateTime(datetime);
            SqlString = $"INSERT INTO notes (date,note,users_id) VALUES('{dateTime.StringMySqlDateTime}','{note}',{userId});";
        }
    }
}
