using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MovieApp.Data
{
    public class Response
    {
        [JsonProperty("page")]
        public int Page { get; set; }


        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }
}
