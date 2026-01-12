using Newtonsoft.Json;

namespace Facade
{
    public class WeatherResponse
    {
        [JsonProperty("main")]
        public MainStats Main { get; set; }

        [JsonProperty("name")]
        public string CityName { get; set; }
    }
    public class MainStats
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }
    }
}