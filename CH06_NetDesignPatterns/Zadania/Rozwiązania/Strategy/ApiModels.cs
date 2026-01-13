using System.Collections.Generic;
using Newtonsoft.Json;

namespace Strategy
{
    public class PexelsResponse
    {
        [JsonProperty("photos")]
        public List<PexelsPhoto> Photos { get; set; }
    }
    public class PexelsPhoto
    {
        [JsonProperty("src")]
        public PexelsSrc Src { get; set; }
    }
    public class PexelsSrc
    {
        [JsonProperty("original")]
        public string OriginalUrl { get; set; }
    }
    public class PixabayResponse
    {
        [JsonProperty("hits")]
        public List<PixabayHit> Hits { get; set; }
    }
    public class PixabayHit
    {
        [JsonProperty("largeImageURL")]
        public string LargeImageUrl { get; set; }
    }
}