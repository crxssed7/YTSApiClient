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
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<YTSResult> ListMovies(string args = "")
        {
            string requestUrl = ApiHelper.ApiClient.BaseAddress + "list_movies.json?" + args;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(requestUrl))
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
