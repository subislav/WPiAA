using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;

namespace Strategy
{
    public class PexelsStrategy : IImageStrategy
    {
        private const string ApiKey = "cMSqhlUpPy3ZJPchFL50b0OfyqAYe4NMcOczTKMoUyNPHegJ8F3lyE06";
        private readonly HttpClient _client;
        public PexelsStrategy()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", ApiKey);
        }
        public async Task<List<string>> SearchPhotosAsync(string query)
        {
            string url = $"https://api.pexels.com/v1/search?query={query}&per_page=3";
            try
            {
                var response = await _client.GetStringAsync(url);
                var data = JsonConvert.DeserializeObject<PexelsResponse>(response);
                return data.Photos.Select(p => p.Src.OriginalUrl).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Pexels Error]: {ex.Message}");
                return new List<string>();
            }
        }
    }
    public class PixabayStrategy : IImageStrategy
    {
        private const string ApiKey = "54181098-e6c021d1702c8a871df907b96";
        private readonly HttpClient _client;

        public PixabayStrategy()
        {
            _client = new HttpClient();
        }
        public async Task<List<string>> SearchPhotosAsync(string query)
        {
            string url = $"https://pixabay.com/api/?key={ApiKey}&q={query}&image_type=photo&per_page=3";
            try
            {
                var response = await _client.GetStringAsync(url);
                var data = JsonConvert.DeserializeObject<PixabayResponse>(response);

                return data.Hits.Select(h => h.LargeImageUrl).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Pixabay Error]: {ex.Message}");
                return new List<string>();
            }
        }
    }
}