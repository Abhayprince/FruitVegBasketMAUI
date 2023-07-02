using CommunityToolkit.Mvvm.ComponentModel;

namespace FruitVegBasket.Models
{
    public partial class CartItem : ObservableObject
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _quantity;

        public decimal Amount => Price * Quantity;
    }
}
