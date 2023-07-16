using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitVegBasket.Api.Data.Entities
{
    [Table(nameof(Offer))]
    public class Offer
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(250)]
        public string Description { get; set; }

        [Required, MaxLength(10)]
        public string Code { get; set; }
        
        [Required, MaxLength(10)]
        public string BgColor { get; set; }

        public bool IsActive { get; set; }
    }
}
