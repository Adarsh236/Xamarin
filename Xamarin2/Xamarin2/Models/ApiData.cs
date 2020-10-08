using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin2.Models
{
    public class ApiData
	{
        [JsonProperty("name")]
        public string Title { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

}
