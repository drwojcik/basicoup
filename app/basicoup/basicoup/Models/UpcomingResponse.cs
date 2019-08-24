using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace basicoup.Models
{
    public class UpcomingResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }
}
