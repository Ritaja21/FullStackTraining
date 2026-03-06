using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
    S
{ 
    internal class Variables
    {
        static void Main(string[] args)
        {
        Console.Write("Enter the number:");
        int num1 = Convert.ToInt32(Console.ReadLine());// direct conversion from string to num
        Console.Wrie("Enter another number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(num1 + num2);
        }
    }
}
