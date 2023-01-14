using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class SelectLogin
    {
        public string SqlString { get; private set; }
        public SelectLogin(string name)
        {
            SqlString = $"SELECT login FROM users WHERE login='{name}';";
        }
    }
}
