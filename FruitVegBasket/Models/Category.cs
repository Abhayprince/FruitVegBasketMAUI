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
        public string Image { get; set; }
        public short ParentId { get; set; }
        public string? Credit { get; set; }

        public bool IsMainCategory => ParentId == 0;


    }
}
