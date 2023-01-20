using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    internal interface IUserRepozitory
    {
        void AddUser(Person user);
        void DeleteUser(Person user);
        Person SelectUser(Person user);

        List<T> Quary();
    }
}
