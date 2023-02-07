using MAUIHandlers.Application.ViewModels;

namespace MAUIHandlers.Application.Views;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage(ItemDetailViewModel objItemDetailViewModel)
	{
		InitializeComponent();
        BindingContext = objItemDetailViewModel;
    }
}
