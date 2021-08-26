using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using YTSApiClient.Models;

namespace YTSApiClient.Endpoints
{
    public class MoviesEndpoint
    {
        /// <summary>
        /// Returns a list of movies. Can take args, in the format argname=value1&argname2=value2. Head over to the YTS docs to see what parameters can be used.
        /// Use parameter "query_term" to search for a certain movie
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<YTSResult> ListMovies(string args = "")
        {
            string requestUrl = ApiHelper.ApiClient.BaseAddress + "list_movies.json?" + args;

            return await SendRequest(requestUrl);
        }

        /// <summary>
        /// Returns the details of a specific movie. Needs an ID to retrieve the movie. Can take args, in the format argname=value1&argname2=value2. 
        /// Head over to the YTS docs to see what parameters can be used.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<YTSResult> MovieDetails(int id, string args = "")
        {
            string requestUrl = ApiHelper.ApiClient.BaseAddress + "movie_details.json?movie_id=" + id + "&" + args;

            return await SendRequest(requestUrl);
        }

        /// <summary>
        /// Gets suggested movies for a certain movie. Needs an ID to get suggestions for.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<YTSResult> MovieSuggestions(int id)
        {
            string requestUrl = ApiHelper.ApiClient.BaseAddress + "movie_suggestions.json?movie_id=" + id;

            return await SendRequest(requestUrl);
        }

        private async Task<YTSResult> SendRequest(string url)
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    YTSResult result = await response.Content.ReadAsAsync<YTSResult>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
