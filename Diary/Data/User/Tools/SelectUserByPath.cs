using Diary.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.User.Tools
{
    public class SelectUserByPath : ISelectUser
    {
        public string PathUser { get; set; }
        public List<Users> UsersSet { get; set; }
        public SelectUserByPath(string path) 
        {
            UsersSet = new List<Users>();
            PathUser = path;
        }
        public List<Users> Select()
        {
            try
            {
                Users user = new Users();

                string[] text = File.ReadAllText(PathUser).Split(new char[] { '*' });

                user.IdUser = Convert.ToInt32(text[0]);
                user.Login = text[1];
                user.Password = text[2];
                user.Email = text[3];

                UsersSet.Add(user);

                return UsersSet;
            }
            catch (Exception)
            {
                UsersSet.Clear();

                return UsersSet;
            }
        }
    }
}
