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

            var m = client.Movies.MovieSuggestions(10).Result;

            foreach (var l in m.data.movies)
            {
                Console.WriteLine(l.title);
            }
            //Console.WriteLine(m.data.movie.title);
            //Console.WriteLine(m.data.movie.description_intro);
            Console.ReadLine();
        }
    }
}
