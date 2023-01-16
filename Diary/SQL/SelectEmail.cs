using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class SelectEmail : SqlCmd
    {
        public SelectEmail(string email)
        {
            SqlString = $"SELECT email FROM users WHERE email='{email}';";
        }
    }
}
