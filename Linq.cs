using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Linq
    {
        static void MainOld(string[] args)
        {
            //LINQ means Language Integrated Query
            //It helps find, sort and filter data
            //No long loops - just short simple commands
            //Works with lists, databases etc

            //Lambda expressions : it is a shortcut to write tiny functions. Helps LINQ know what to look for
            // g => g.Title means 'Get the title' g is the temporary name for each item

            var games = new List<Game>
            {
                new Game {Title = "The Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
                new Game {Title = "Super Mario Bros.", Genre = "RPG", ReleaseYear = 1985, Rating = 9.2, Price =  50 },
                new Game {Title = "Elden Ring", Genre = "RPG", ReleaseYear = 2022, Rating = 9.8, Price = 70 },
                new Game {Title = "Stradew Valley", Genre = "RPG", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
                new Game {Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 }
            };

            //var allGames = games.Select(game => game.Title); // to choose all 

            //var rpgGames = games.Where(game => game.Genre == "RPG");//to choose with specific feature needed
            //foreach (var game in rpgGames) {
            //    Console.WriteLine(game.Title);
            //}

            //foreach (var title in allGames)
            //{
            //    Console.WriteLine(title);
            //}

            //var modernGamesExist = games.Any(game => game.ReleaseYear > 2000);//provide boolean output of a condition
            //Console.WriteLine($"Are there any modern games? {modernGamesExist}");

            //var sortedByYear = games.OrderByDescending(game => game.ReleaseYear);//for sorting orderby (ascending) orderbydescending
            //foreach (var game in sortedByYear)
            //{
            //    Console.WriteLine(game.Title);
            //}

            //var averageGamePrice = games.Average(game => game.Price);
            //Console.WriteLine($"The average game price is: {averageGamePrice}");

            //var maxRating = games.Max(game => game.Rating);
            //Console.WriteLine($"The maximum rating of the game is: {maxRating}");

            //var gamesByGroup = games.GroupBy(g => g.Genre);
            //foreach (var group in gamesByGroup)
            //{
            //    Console.WriteLine($"Genre:{group.Key}");

            //    foreach (var game in group)
            //    {
            //        Console.WriteLine(game.Title);
            //    }
            //}


            //var budgetAdventureGame = games
            //    .Where(g => g.Genre == "RPG" && g.Price <= 60)
            //    .OrderBy(g => g.Rating)
            //    .Select(g => $"{g.Title} - {g.Price}");

            //foreach(var game in budgetAdventureGame)
            //{
            //    Console.WriteLine(game);
            //}


            //var paginatedGames = games.Skip(2).Take(3); //Pagination: breaking large data into smaller chunks(pages) instead of showing everything at once.
            //foreach (var game in paginatedGames)
            //{
            //    Console.WriteLine(game.Title);
            //}


            //this is two different ways of writing the linq 
            //var adventureGames = games.Where(g => g.Genre == "Adventure");

            //var adventureGamesQuery = from g in games
            //                          where g.Genre == "Adventure" 
            //                          select g;

            //foreach (var game in adventureGames)
            //{
            //    Console.WriteLine(game.Title);
            //}

            var cheapestGames = games.OrderBy(g => g.Price).First();
            Console.WriteLine($"{cheapestGames.Title} - {cheapestGames.Price} - {cheapestGames.Rating}");
        }
    }
}
