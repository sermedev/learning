using BlazorApp.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorApp.Services
{
    public class ProducService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public ProducService(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions)
        {
            _httpClient = httpClient;
            _jsonSerializerOptions = jsonSerializerOptions;
        }

        public async Task<List<Product>?> Get()
        {
            var response = await _httpClient.GetAsync("v1/products");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonSerializer.Deserialize<List<Product>>(content, _jsonSerializerOptions);
        }

        public async Task Add(Product product)
        {
            var response = await _httpClient.PostAsync("v1/products", JsonContent.Create(product));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }

        public async Task Delete(int productId)
        {
            var response = await _httpClient.DeleteAsync($"v1/products/{productId}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
        }
    }
}
