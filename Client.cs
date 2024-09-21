using System.Text;
using System.Text.Json;

namespace game_sdk
{
    public class Client
    {
        // Default Url
        private const string mainUrl = "https://game-server-nu.vercel.app";

        private readonly HttpClient _httpClient;

        public Client(string baseUrl = mainUrl, string apiKey = "")
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl),
            };

            //_httpClient.DefaultRequestHeaders.Add("")
        }

        public async Task<T> GetAsync<T>(string endPoint)
        {
            var response = await _httpClient.GetAsync(endPoint);

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<T>(content);
        }

        public async Task<T> PostAsync<T>(string endPoint, object data)
        {
            var content = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
            Console.WriteLine(content); // "System.Net.Http.StringContent"

            var response = await _httpClient.PostAsync(endPoint, content);

            response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();


            return JsonSerializer.Deserialize<T>(responseContent);
        }

    }
}
