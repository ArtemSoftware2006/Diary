using Diary.Data.Entity;
using MySqlX.XDevAPI.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.User
{
    abstract public class AbstractUser
    {
        abstract public void Create(Users user);
        abstract public void Update(Users user);
        abstract public void Delete();
        abstract public List<Users> Select(ISelectUser condition);
        abstract public bool Find(IFindUser condition);

    }
}
