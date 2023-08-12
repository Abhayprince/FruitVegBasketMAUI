namespace FruitVegBasket.Controls;

public partial class CartControl : ContentView
{
    public static readonly BindableProperty CountProperty =
        BindableProperty.Create(nameof(Count), typeof(int), typeof(CartControl), 0, propertyChanged: OnCountChanged);
    public CartControl()
    {
        InitializeComponent();
    }

    public int Count
    {
        get => (int)GetValue(CountProperty);
        set => SetValue(CountProperty, value);
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        container.Scale = 0;
    }

    private async Task AnimateContainer(AnimationType animationType)
    {
        switch(animationType)
        {
            case AnimationType.In:
                await Task.WhenAll(container.ScaleTo(1.5), container.RotateTo(360));
                await Pulse();
                break;
            case AnimationType.Out:
                await Task.WhenAll(container.ScaleTo(0), container.RotateTo(-360));
                break;
            default:
                await Pulse();
                break;
        }

        async Task Pulse()
        {
            await container.ScaleTo(1, 180);
            await container.ScaleTo(1.2, 180);
            await container.ScaleTo(1, 180);
            await container.ScaleTo(1.2, 180);
            await container.ScaleTo(1, 180);
        }
    }
    enum AnimationType
    {
        Out,
        In,
        Pulse
    }
    private static void OnCountChanged(BindableObject bindable, object oldValue, object newValue)
    {
        int oldCount = (int)oldValue;
        int newCount = (int)newValue;

        if(oldCount != newCount)
        {
            var cartControl = (CartControl)bindable;
            if(newCount < 1)
            {
                // There are no items in the cart
                // hide this

                cartControl.AnimateContainer(AnimationType.Out);
            }
            else if(oldCount < 1 && newCount > 1)
            {
                // This is the first item to be added to the cart
                // Show this
                cartControl.AnimateContainer(AnimationType.In);
            }
            else
            {
                //Increase/descrease qunatity
                cartControl.AnimateContainer(AnimationType.Pulse);
            }
        }
    }
}