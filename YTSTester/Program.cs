using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTSApiClient;

namespace YTSTester
{
    class Program
    {
        static void Main(string[] args)
        {
            YTSClient client = new YTSClient();

            Console.WriteLine("What movie do you want to search for?");
            string query = Console.ReadLine();

            var results = client.Movies.ListMovies("query_term=" + query).Result;

            foreach (var result in results.data.movies)
            {
                Console.WriteLine(result.title + " (" + result.year + ") | " + result.id);
            }

            Console.WriteLine("Now enter the movie ID. Needs to be an integer:");
            int id = Convert.ToInt32(Console.ReadLine());

            var movie = client.Movies.MovieDetails(id).Result;
            Console.WriteLine(movie.data.movie.title);
            Console.WriteLine(movie.data.movie.description_full);

            Console.ReadLine();
        }
    }
}
