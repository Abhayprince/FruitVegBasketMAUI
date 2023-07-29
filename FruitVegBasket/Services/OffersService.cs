using FruitVegBasket.Models;

namespace FruitVegBasket.Services
{
    public class OffersService : BaseApiService
    {
        public OffersService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
        public async Task<IEnumerable<Offer>> GetActiveOffersAsync()
        {
            var response = await HttpClient.GetAsync("/masters/offers");
            return await HandleApiResponseAsync(response, Enumerable.Empty<Offer>());
        }
    }
}
