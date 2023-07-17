using FruitVegBasket.Constants;
using FruitVegBasket.Models;
using System.Text.Json;

namespace FruitVegBasket.Services
{
    public class CategoryService
    {
        public CategoryService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        private IEnumerable<Category>? _categories;
        private readonly IHttpClientFactory _httpClientFactory;

        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (_categories is null)
            {
                var httpClient = _httpClientFactory.CreateClient(AppConstants.HttpClientName);

                var response = await httpClient.GetAsync("/masters/categories");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(content))
                    {
                        _categories = JsonSerializer.Deserialize<IEnumerable<Category>?>(content, new JsonSerializerOptions
                        {
                            PropertyNameCaseInsensitive = true
                        });
                    }
                }
                else
                {
                    return Enumerable.Empty<Category>();
                }
            }
            return _categories;
        }

        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync())
            .Where(c => c.ParentId == 0);
    }
}
