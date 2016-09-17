using System;
using Newtonsoft.Json;

namespace SevenKeyDecisions.Core
{
    public class PhotoInfo
    {
        [JsonProperty("albumId")]
        public string AlbumId { get; set; }
        
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("title")]
        public string Title { get; set; }
        
        [JsonProperty("url")]
        public Uri Url { get; set; }
        
        [JsonProperty("thumbnailUrl")]
        public Uri Thumbnail { get; set; }
    }
}