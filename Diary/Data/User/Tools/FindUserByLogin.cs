using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.User.Tools
{
    public class FindUserByLogin : IFindUser
    {
        public string FilePath { get; set; }
        public string Login { get; set; }
        public FindUserByLogin(string login) 
        {
            Login = login;
        }
        public bool Find()
        {
            return Login == File.ReadAllText(FilePath).Split(new char[] { '*' })[0];
        }
    }
}
