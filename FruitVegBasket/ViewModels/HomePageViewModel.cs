using CommunityToolkit.Mvvm.ComponentModel;
using FruitVegBasket.Models;
using FruitVegBasket.Services;
using FruitVegBasket.Shared.Dtos;
using System.Collections.ObjectModel;

namespace FruitVegBasket.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly CategoryService _categoryService;
        private readonly OffersService _offersService;
        private readonly ProductsService _productsService;

        public HomePageViewModel(CategoryService categoryService, OffersService offersService
            , ProductsService productsService)
        {
            _categoryService = categoryService;
            _offersService = offersService;
            _productsService = productsService;
        }
        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Offer> Offers { get; set; } = new();
        public ObservableCollection<ProductDto> PopularProducts { get; set; } = new();

        [ObservableProperty]
        private bool _isBusy = true;

        public async Task InitializeAsync()
        {
            try
            {
                var offersTask = _offersService.GetActiveOffersAsync();
                var popularProductsTask = _productsService.GetPopularProductsAsync();
                foreach (var category in await _categoryService.GetMainCategoriesAsync())
                {
                    Categories.Add(category);
                }
                foreach (var offer in await offersTask)
                {
                    Offers.Add(offer);
                }
                foreach (var product in await popularProductsTask)
                {
                    PopularProducts.Add(product);
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
