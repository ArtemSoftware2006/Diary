﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.SQL
{
    internal class AddUser
    {
        public string SqlString { get; private set; }
        public AddUser(string name, string password, string email)
        {
            SqlString = $"INSERT INTO users (login, password, email) VALUES('{name}','{password}','{email}');";
        }
    }
}
