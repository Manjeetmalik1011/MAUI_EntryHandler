using MAUIHandlers.Application.ViewModels;

namespace MAUIHandlers.Application.Views;

public partial class RegistrationPage : ContentPage
{
    internal RegistrationViewModel ViewModel { get; set; }
    public RegistrationPage(RegistrationViewModel objRegistrationViewModel)
	{
		InitializeComponent();
        ViewModel = objRegistrationViewModel;
        this.BindingContext = ViewModel;
    }
}
