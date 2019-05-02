using System;
using System.Linq;
using Abstraction;
using Abstraction.Entity;
using System.Collections.Generic;
namespace Core
{
    public class UserService : IUser
    {
        public List<TestTable> GetUsers()
        {
            try
            {
                using (var context = new Data.TestDataContext.SampleContext())
                {
                    return context.TestTable.ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        public bool AddUser(TestTable obj)
        {
            try
            {
                using (var context = new Data.TestDataContext.SampleContext())
                {
                    int i = context.TestTable.Count() == 0 ? 0 : context.TestTable.Max(x => x.UserID);
                    obj.UserID = ++i;
                    context.TestTable.Add(obj);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
