using CommunityToolkit.Mvvm.ComponentModel;

namespace FruitVegBasket.Models
{
    public class Category
    {
        public Category(short id, string name, short parentId, string image, string credit)
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
        }

        public short Id { get; set; }
        public string Name { get; set; }

        //public string Image { get; set; }
        private string _image;
        public string Image
        {
            get => _image;
            set
            {
                _image = $"https://raw.githubusercontent.com/Abhayprince/FruitVegBasketMAUI/part-7/FruitVegBasket.Api/wwwroot/images/categories/{value}";
            }
        }

        public short ParentId { get; set; }
        public string? Credit { get; set; }

        public bool IsMainCategory => ParentId == 0;
        //public string ImageUrl => $"https:/localhost:12345/images/categories/{Image}";
    }
}
