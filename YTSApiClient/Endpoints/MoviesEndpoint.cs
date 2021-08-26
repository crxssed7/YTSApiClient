using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using YTSApiClient.Models;

namespace YTSApiClient.Endpoints
{
    public class MoviesEndpoint
    {
        public async Task<YTSResult> ListMovies()
        {
            string requestUrl = "https://yts.mx/api/v2/list_movies.json";

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
