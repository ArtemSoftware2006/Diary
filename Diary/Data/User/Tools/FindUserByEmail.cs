using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.User.Tools
{
    public class FindUserByEmail : IFindUser
    {
        public string FilePath { get; set; }
        public string Email { get; set; }
        public FindUserByEmail(string email, string path)
        {
            Email = email;
            FilePath = path;
        }
        public bool Find()
        {
            try
            {
                return Email == File.ReadAllText(FilePath).Split(new char[] { '*' })[3];

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
