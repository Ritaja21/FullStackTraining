using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Methods
    {
        static void methodsMain(string[] args)
        {
           
            
            BookFine();
        }
        static void BookFine()
        {
            Console.Write("Did you registered for the store: ");
            string ans = Console.ReadLine();
            bool isRegistered = ans.ToLower() == "yes";
            if (isRegistered)
            {
                Console.WriteLine("Welcome Back");
                Console.Write("Did you renew the book within 7days: ");
                string renewed = Console.ReadLine().ToLower();
                if(renewed == "no")
                {
                    Console.WriteLine("Fine Charged of Rs. 50");
                }
                else
                {
                    Console.WriteLine("No Fine Charged");
                }
            }
            else
            {
                Console.WriteLine("Please register first");
            }
        }
    }
       
}
