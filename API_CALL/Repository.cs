using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_CALL
{
    public class Repository
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("html_url")]
        public Uri HomeUrl { get; set; }
        [JsonProperty("homepage")]
        public Uri HomePage { get; set; }
        [JsonProperty("watchers")]
        public int Watchers { get; set; }


    }
}
