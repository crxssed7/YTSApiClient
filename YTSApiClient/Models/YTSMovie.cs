﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTSApiClient.Models
{
    public class YTSMovie
    {
        public int id { get; set; }
        public string url { get; set; }
        public string imdb_code { get; set; }
        public string title { get; set; }
        public string title_english { get; set; }
        public string title_long { get; set; }
        public string slug { get; set; }
        public int year { get; set; }
        public float rating { get; set; }
        public int runtime { get; set; }
        public List<string> genres { get; set; }
        public int download_count { get; set; }
        public int like_count { get; set; }
        public string description_intro { get; set; }
        public string description_full { get; set; }
        public string yt_trailer_code { get; set; }
        public string language { get; set; }
        public string mpa_rating { get; set; }
        public string background_image { get; set; }
        public string background_image_original { get; set; }
        public string small_cover_image { get; set; }
        public string medium_cover_image { get; set; }
        public string large_cover_image { get; set; }
        public List<YTSTorrent> torrents { get; set; }
        public string date_uploaded { get; set; }
        public int date_uploaded_unix { get; set; }
    }
}
