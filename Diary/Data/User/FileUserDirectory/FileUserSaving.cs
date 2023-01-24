using Diary.Data.Entity;
using Diary.Data.Interfaces;
using Diary.Data.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Directory
{
    public class FileUserSaving : AbstractUser
    {
        public string PathUser { get; set; }
        public FileUserSaving(string pathUser)
        {
            PathUser = pathUser;
        }

        public override void Create(Users user)
        {
            File.WriteAllText(PathUser, user.IdUser.ToString() + "*" + user.Login + "*" + user.Password + "*" + user.Email);
        }

        public override void Delete()
        {
            File.Delete(PathUser);
        }

        public override bool Find(IFindUser condition)
        {
            return condition.Find();
        }

        public override List<Users> Select(ISelectUser condition)
        {
            return condition.Select();
        }

        public override void Update(Users user)
        {
            File.WriteAllText(PathUser, user.IdUser.ToString() + "*" + user.Login + "*" + user.Password + "*" + user.Email);
        }
    }
}
