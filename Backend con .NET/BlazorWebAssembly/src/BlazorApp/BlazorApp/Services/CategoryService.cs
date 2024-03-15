using BlazorApp.Models;
using System.Text.Json;

namespace BlazorApp.Services
{
    public class CategoryService
    {

        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }
        public async Task<List<Category>?> Get()
        {
            var response = await _httpClient.GetAsync("/v1/Categories");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            return JsonSerializer.Deserialize<List<Category>>(content, _jsonSerializerOptions);

        }

    }
}
