using FruitVegBasket.Constants;
using System.Text.Json;

namespace FruitVegBasket.Services
{
    public class BaseApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BaseApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        protected JsonSerializerOptions DefaultSerializerOptions = new() { PropertyNameCaseInsensitive = true };

        protected HttpClient HttpClient => _httpClientFactory.CreateClient(AppConstants.HttpClientName);

        protected TData Deserialize<TData>(string jsonData) =>
            JsonSerializer.Deserialize<TData>(jsonData, DefaultSerializerOptions);

        protected async Task<TData> HandleApiResponseAsync<TData>(HttpResponseMessage response, TData defaultValue)
        {
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    return Deserialize<TData>(content);
                }
            }
            return defaultValue;
        }
    }
}
