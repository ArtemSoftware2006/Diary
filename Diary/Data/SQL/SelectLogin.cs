using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class SelectUser : SqlCmd
    {
        public SelectUser(string name)
        {
            SqlString = $"SELECT login FROM users WHERE login='{name}';";
        }
    }
}
