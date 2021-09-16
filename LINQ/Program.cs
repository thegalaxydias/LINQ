using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                 new User {role = "admin", login = "carl", password = 123},
                 new User {role = "customer", login = "tom", password = 890},
                 new User {role = "manager", login = "jo", password = 000},
                 new User {role = "user", login = "ron", password = 99},
                 new User {role = "superadmin", login = "jef", password = 00},
            };

            var output1 = users.Where(u => u.role == "admin").FirstOrDefault();
            var output2 = users.Where(u => u.login.StartsWith("a"));
            var output3 = users.OrderBy(u => u.login);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
        }

    }

    public class User {

        public string role { get; set; }
        public string login { get; set; }
        public int password { get; set; }
        

        
    }
}


        
      


    
