using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{ 
     class Program
    {
        static void Main(string[] args)
        {

            //Book book1 = new Book("Invisible","James Patterson", "Crime Thriller", 2.0); //object: instance of a class
            //Console.WriteLine(Book.bookCount);
            //Book book2 = new Book("The Book Thief", "Markus Zusak", "Historical Fiction", 4.5);
            //Console.WriteLine(Book.bookCount);
            //FictionBook book3 = new FictionBook("Harry Potter", "JK Rowling", "Fiction", 4, "Fantasy");



            var book = new List<Book>
            {
            new Book("Invisible", "James Patterson", "Crime Thriller", 2.0 ),
            new Book("The Book Thief", "Markus Zusak", "Historical Fiction", 4.5 ),
            };


            var fictionBook = new List<FictionBook>
           {
              new FictionBook("Harry Potter", "JK Rowling", "Fiction", 4, "Fantasy" ),
           new FictionBook("The Mahabrata Secret", "Alexandre Conan Doyle", "Fiction", 3.5, "Mythological Mystery"),
           new FictionBook("The Hunger Games", "Suzzane Collins", "Fiction", 4.7, "Dystopian Fiction"),
           };



            //foreach (Book book in Library)
            //{
            //    if (book.IsRecommended())
            //    {
            //        Console.WriteLine("Recommended Book");
            //        book.DisplayBookInfo();
            //    }
            //    else
            //    {
            //        Console.WriteLine("This Book is not recommended");
            //    }
            //}

            var recommendedFictionBooks = fictionBook
                                         .Where(g => g.IsRecommended())
                                          .OrderBy(g => g.Review)
                                          .ToList();
            Console.WriteLine("Recommended Fiction Books");
            foreach (var games in recommendedFictionBooks){
                games.DisplayBookInfo();
            }

            //if (book1.IsRecommended())
            //{
            //    Console.WriteLine("Recommended Book:");
            //    book1.DisplayBookInfo();
            //}
            //else
            //{
            //    Console.WriteLine("This book is not recommended:)");
            //}

            //if (book2.IsRecommended())
            //{
            //    Console.WriteLine("Recommended Book:");
            //    book2.DisplayBookInfo();
            //}
            //else
            //{
            //    Console.WriteLine("This book is not recommended:)");
            //}

            //if (book3.IsRecommended())
            //{
            //    Console.WriteLine("Recommended Book:");
            //    book3.DisplayBookInfo();
            //}
            //else
            //{
            //    Console.WriteLine("This book is not recommended:)");
            //}

        }
        //static method belongs to class itself and we dont need to create an object for that class for eg the math class ; sqrt is a static method 
    }
}
