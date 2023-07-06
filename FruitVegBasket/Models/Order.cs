using FruitVegBasket.Shared.Enumerations;

namespace FruitVegBasket.Models
{
    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; } = DateTime.Now;

        public decimal TotalAmount => Items.Sum(i => i.Amount);

        public OrderStatus Status { get; set; } = OrderStatus.Placed;

        public Color Color => _orderStatusColorsMap[Status];

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorsMap =
            new Dictionary<OrderStatus, Color>
            {
                [OrderStatus.Placed] = Colors.Yellow,
                [OrderStatus.Confirmed] = Colors.Blue,
                [OrderStatus.Delivered] = Colors.Green,
                [OrderStatus.Cancelled] = Colors.Red,
            };
    }
}
