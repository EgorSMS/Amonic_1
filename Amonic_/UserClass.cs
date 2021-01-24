using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amonic_
{
    class UserClass
    {
        var sw = new Stopwatch();
        sw.Start();

        string logins = ds.Tables[0].AsEnumerable().Select(dataRow => new User
        {
            RoleID = dataRow.Field<int>("RoleID"),
            OfficeID = dataRow.Field<int>("OfficeID"),
            Login = dataRow.Field<string>("Email"),
            Password = dataRow.Field<string>("Password"),
            Firstname = dataRow.Field<string>("Firstname"),
            Lastname = dataRow.Field<string>("Lastname"),
            Birthdate = dataRow.Field<DateTime>("Birthdate"),
            Active = dataRow.Field<int>("Active")
        }).ToList();
    }
}
