using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitVegBasket.Api.Data.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(180)]
        public string? Image { get; set; }
        public decimal Price { get; set; }

        public short CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
