using MAUIHandlers.Application.ViewModels;

namespace MAUIHandlers.Application.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutViewModel objAboutViewModel)
	{
		InitializeComponent();
		BindingContext = objAboutViewModel;

    }
}
