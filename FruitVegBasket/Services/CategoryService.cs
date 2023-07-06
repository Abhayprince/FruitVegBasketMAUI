using FruitVegBasket.Models;

namespace FruitVegBasket.Services
{
    public class CategoryService
    {
        private IEnumerable<Category>? _categories;
        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (_categories is null)
            {
                var categories = new List<Category>();

                var fruits = new List<Category>
                {
                    new (1, "Fruits", 0, "fruits.png", "Photo by <a href=\"https://unsplash.com/@juliazolotova?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Julia Zolotova</a> on <a href=\"https://unsplash.com/photos/M_xIaxQE3Ms?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (2, "Seasonal Fruits", 1, "seasonal_fruits.png", "Photo by <a href=\"https://unsplash.com/@rejaul_creativedesign?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rejaul Karim</a> on <a href=\"https://unsplash.com/photos/uI3SmaQeu6o?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (3, "Exotic Fruits", 1, "exotic_fruits.png", "Photo by <a href=\"https://unsplash.com/@alschim?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Alexander Schimmeck</a> on <a href=\"https://unsplash.com/photos/9YVh9yQvvvk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  ")
                };
                categories.AddRange(fruits);

                var vegetables = new List<Category>
                {
                    new (4, "Vegetables", 0, "vegetables.png", "Photo by <a href=\"https://unsplash.com/@marisolbenitez?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Marisol Benitez</a> on <a href=\"https://unsplash.com/photos/QvkAQTNj4zk?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (5, "Green Vegetables", 4, "green_vegetables.png", "Photo by Viktoria  Slowikowska: https://www.pexels.com/photo/sweet-corn-and-green-vegetables-on-blue-surface-5678106/"),
                    new (6, "Leafy Vegetables", 4, "leafy_vegetables.png", "Photo by <a href=\"https://unsplash.com/@woonsa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Soo Ann Woon</a> on <a href=\"https://unsplash.com/photos/0l_NXp3StHE?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (7, "Salads", 4, "salads.png", "Photo by <a href=\"https://unsplash.com/@nadineprimeau?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Nadine Primeau</a> on <a href=\"https://unsplash.com/photos/-ftWfohtjNw?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                };
                categories.AddRange(vegetables);

                var dairy = new List<Category>
                {
                    new (8, "Dairy", 0, "dairy.png", "Photo by <a href=\"https://unsplash.com/@picoftasty?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mae Mu</a> on <a href=\"https://unsplash.com/photos/ru4jyDiLHsI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (9, "Milk, Curd & Yogurts", 8, "milk_curd_yogurt.png", "Photo by <a href=\"https://unsplash.com/@mehrshadr?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Mehrshad Rajabi</a> on <a href=\"https://unsplash.com/photos/P7MkoYvSnLI?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (10, "Butter & Cheese", 8, "butter_cheese.png", "Photo by Elle Hughes: https://www.pexels.com/photo/three-assorted-varieties-of-cheese-near-tableknife-1963288/"),
                };
                categories.AddRange(dairy);

                var eggsMeat = new List<Category>
                {
                    new (11, "Eggs & Meat", 0, "eggs_meat.png", "Photo by <a href=\"https://unsplash.com/@rudy_issa?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Rudy Issa</a> on <a href=\"https://unsplash.com/photos/KVacTm0QeEA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (12, "Eggs", 11, "eggs.png", "Photo by <a href=\"https://unsplash.com/@erol?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Erol Ahmed</a> on <a href=\"https://unsplash.com/photos/leOh1CzRZVQ?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (13, "Meat", 11, "meat.png", "Photo by <a href=\"https://unsplash.com/@shootdelicious?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Eiliv Aceron</a> on <a href=\"https://unsplash.com/photos/AQ_BdsvLgqA?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                    new (14, "Seafood", 11, "seafood.png", "Photo by <a href=\"https://unsplash.com/pt-br/@maxmota?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Max Mota</a> on <a href=\"https://unsplash.com/photos/N6BTNbaKZMo?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText\">Unsplash</a>\r\n  "),
                };
                categories.AddRange(eggsMeat);
                _categories = categories;
            }
            return _categories;
        }

        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync())
            .Where(c => c.ParentId == 0);
    }
}
