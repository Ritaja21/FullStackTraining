using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
     
    class Lists
    {
        static void MainThree(string[] args)
        {
            List<Users> users = new List<Users>();

          

            users.Add(new Users("Steve"));
            users.Add(new Users("Karen"));
            users.Add(new Users("Josh"));

            foreach (Users user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
   class Users
    {
        public String username;

        public Users(String username)
        {
            this.username = username;
        }
            public override string ToString()
            {
                return username;
            }
    }
}
