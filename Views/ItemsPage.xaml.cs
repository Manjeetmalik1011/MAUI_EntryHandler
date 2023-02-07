using MAUIHandlers.Application.ViewModels;

namespace MAUIHandlers.Application.Views;

public partial class ItemsPage : ContentPage
{
	public ItemsPage(ItemsViewModel objItemsViewModel)
	{
		InitializeComponent();
		BindingContext = objItemsViewModel;
    }
}
