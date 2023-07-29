using FruitVegBasket.ViewModels;

namespace FruitVegBasket.Pages;

public partial class HomePage : ContentPage
{
    private readonly HomePageViewModel _viewModel;

    public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }

    private void ProductsListControl_AddRemoveCartClicked(object sender, Controls.ProductCartItemChangeEventArgs e)
    {
        if(e.Count > 0)
        {
            _viewModel.AddToCartCommand.Execute(e.ProductId);
        }
        else
        {
            _viewModel.RemoveFromCartCommand.Execute(e.ProductId);
        }
    }
}