using Diary.Data.Services;
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
        public FindUserByLogin(string login, string path) 
        {
            Login = login;
            FilePath = path;
        }
        public bool Find()
        {
            try
            {
                return Login == File.ReadAllText(FilePath).Split(new char[] { '*' })[1];
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
