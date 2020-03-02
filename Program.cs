using System;

namespace Treehouse.MediaLibrary
{
    class Program
    {
        static void Main()
        {
            //instantiating class instances
            var album = new Album();
            album.Title = "Yello Submarine";
            album.Artist = "The Beatles";

            var book  = new Book();
            book.Title = "Moby-Dick";
            book.Author = "Herman Melville";


            var movie = new Movie();
            movie.Title = "Lawrence of Arabia";
            movie.Director = "David Lean";

            Console.WriteLine("Hello World!");
            Console.WriteLine("Album: " + album.Title + " by " +  album.Artist);
            Console.WriteLine("Book: " + book.Title + " by " + book.Author);
            Console.WriteLine("Movie: " + movie.Title + " by " + movie.Director);

           


        }
    }
}
