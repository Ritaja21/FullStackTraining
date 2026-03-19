using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
     class Book
    {
        public string title;
        public string author;
        public string genre;
        private double review; // setting it private so that it cant be updated by other invalid numbers Encapsulation
        public static int bookCount = 0; // this attribute is only used by the class and not by the object

        public Book(string a_title, string a_author, string a_genre, double a_review)
        {
            title = a_title;
            author = a_author;
            genre = a_genre;
            Review = a_review;
            bookCount++;
        }

        public double Review // using of getters and setters
        {
            get { return review; }
            set { if (value >= 1.0 && value <= 5.0)
                  {
                    review = value;
                  }
                  else
                  {
                    review = 3.0;
                  }
                }
        }

        public bool IsRecommended () //object method for recommending book on a given review
        {
            return Review >= 4.0;
        }

        public virtual void DisplayBookInfo()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Genre: " + genre);
        }
    }
}
