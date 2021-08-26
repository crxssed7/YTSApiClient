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

            var m = client.Movies.ListMovies();

            foreach (var l in m.Result.data.movies)
            {
                Console.WriteLine(l.title);
            }

            Console.ReadLine();
        }
    }
}
