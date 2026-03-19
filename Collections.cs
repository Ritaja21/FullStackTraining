using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Collections
    {
        static void MainTwo(string[] args) {
            //List = data structure that represents a list of objects that can be accesses by index.
            //Similar to array, but can dynamically increase/decrease in size
            // using System.Collections.Generic;

            List<string> food = new List<string>();

            food.Add("pizza");
            food.Add("Hamburger");
            food.Add("Hotdog");
            food.Add("Fries");

            //food.Remove("Fries");
            //food.Insert(0, "sushi");
            //food.Count;
            //food.IndexOf("pizza");
            //food.LastIndexOf("fries");
            //food.Contains("pizza");
            //food.Sort() // alphabetical 
            //food.Reverse();
            //food.Clear();

            //String[] foodArray = food.ToArray();

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }
        }

    }
}
