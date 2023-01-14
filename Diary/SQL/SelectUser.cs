using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diary.SQL
{
    internal class SelectUser
    {
        public string SqlString { get; private set; }
        public SelectUser(string name, string password) 
        {
            SqlString = $"SELECT login FROM users WHERE login='{name}' AND password='{password}';";
        }
    }
}
