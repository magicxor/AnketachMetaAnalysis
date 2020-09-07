using System;
using Newtonsoft.Json;

namespace AnketachMetaAnalysis.Models
{
    public class Message
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        //[JsonProperty("text")]
        //public object Text { get; set; }

        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageId { get; set; }

        [JsonProperty("edited", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Edited { get; set; }

        [JsonProperty("reply_to_message_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplyToMessageId { get; set; }
    }
}