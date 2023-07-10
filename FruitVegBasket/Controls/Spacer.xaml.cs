namespace FruitVegBasket.Controls;

public partial class Spacer : ContentView
{
	public Spacer()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty SpaceProperty = 
		BindableProperty.Create(nameof(Space), typeof(int), typeof(Spacer), defaultValue: 10);

	public int Space
	{
		get => (int)GetValue(SpaceProperty);
		set => SetValue(SpaceProperty, value);
	}

}