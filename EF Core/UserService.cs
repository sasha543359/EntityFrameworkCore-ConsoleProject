using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    public class UserService
    {
        public User AddUser(int age, string name)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = new User()
                {
                    Name = name,
                    Age = age,
                };

                db.Users.Add(user);
                db.SaveChanges();

                return user;
            }
        }
    }
}
