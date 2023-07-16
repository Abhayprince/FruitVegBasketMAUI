using FruitVegBasket.Shared.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FruitVegBasket.Api.Data.Entities
{
    [Table(nameof(Order))]
    public class Order
    {
        [Key]
        public long Id { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Placed;

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual User User { get; set; }
    }
}
