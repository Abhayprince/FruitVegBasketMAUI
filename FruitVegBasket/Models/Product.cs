namespace FruitVegBasket.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public short CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
