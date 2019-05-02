using System;
using System.Collections.Generic;
using System.Text;
using Abstraction.Entity;

namespace Abstraction
{
   public interface IUser
    {
        List<TestTable> GetUsers();
        bool AddUser(TestTable obj);
    }
}
