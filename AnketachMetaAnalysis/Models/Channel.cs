using System.Collections.Generic;
using Newtonsoft.Json;

namespace AnketachMetaAnalysis.Models
{
    public class Channel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }
}
