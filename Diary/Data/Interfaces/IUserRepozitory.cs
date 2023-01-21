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
        void CreateUser(Person user);
        void DeleteUser(Person user);
        Person ReadtUser(Person user);

        List<DataSet> Query(IUserSpecification userSpecification);
    }
}
