using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class SelectPerson : SqlCmd
    {
        public SelectPerson(string login)
        {
            SqlString = $"SELECT id,login,password,email FROM users WHERE login='{login}'";
        }
    }
}
