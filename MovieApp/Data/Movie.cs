using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class Movie
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public string Release_Date { get; set; }

        [JsonProperty("vote_average")]
        public string Vote_Average { get; set; }

        [JsonProperty("vote_count")]
        public string Vote_Count { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_Path { get; set; }
    }
}
