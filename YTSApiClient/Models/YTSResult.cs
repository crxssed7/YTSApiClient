using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTSApiClient.Models
{
    public class YTSResult
    {
        public string status { get; set; }
        public string status_message { get; set; }
        public YTSData data { get; set; }
    }
}
