using MAUIHandlers.Application.ViewModels;

namespace MAUIHandlers.Application.Views;

public partial class LoadingPage : ContentPage
{
     LoadingViewModel ViewModel { get; set; }
    public LoadingPage(LoadingViewModel objLoadingViewModel)
	{
		InitializeComponent();
        ViewModel = objLoadingViewModel;
        this.BindingContext = ViewModel;

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.Init();
    }
}
