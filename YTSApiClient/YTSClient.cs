using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YTSApiClient.Endpoints;

namespace YTSApiClient
{
    public class YTSClient
    {
        public MoviesEndpoint Movies = new MoviesEndpoint();

        public YTSClient()
        {
            ApiHelper.InitClient();
        }
    }
}
