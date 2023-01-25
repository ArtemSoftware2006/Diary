using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.User.Tools
{
    internal class FindUserByLoginAndPwd : IFindUser
    {
        public string PathFile { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public FindUserByLoginAndPwd(string path, string login, string password)
        {
            PathFile = path;
            Login = login;
            Password = password;
        }
        public bool Find()
        {
            return (File.ReadAllText(PathFile).Split(new char[] { '*' })[1] == Login) &&
                (File.ReadAllText(PathFile).Split(new char[] { '*' })[2] == Password);
        }
    }
}
