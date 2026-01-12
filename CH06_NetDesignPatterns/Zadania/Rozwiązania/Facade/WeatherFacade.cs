using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Facade
{
    public class WeatherFacade
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        public WeatherFacade(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }
        public async Task<double> GetTemperatureAsync(string city)
        {
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
            try
            {
                string jsonResponse = await _httpClient.GetStringAsync(url);
                WeatherResponse weatherData = JsonConvert.DeserializeObject<WeatherResponse>(jsonResponse);
                return weatherData.Main.Temperature;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"[BŁĄD API]: {e.Message}");
                throw;
            }
        }
    }
}