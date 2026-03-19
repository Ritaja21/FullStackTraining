using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class FictionBook: Book // inheritance
    {
        public string StoryType;

        public FictionBook (string a_title, string a_author, string a_genre, double a_review, string a_storytype ): base(a_title,a_author, a_genre, a_review)
        {
            StoryType = a_storytype;
        }

        public override void DisplayBookInfo() // method overriding polymorphism
        {
            base.DisplayBookInfo();
            Console.WriteLine("StoryType: " + StoryType);
        }
    }
}
