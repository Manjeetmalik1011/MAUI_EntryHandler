namespace MAUIHandlers.Application.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(ViewModels.LoginViewModel objLoginViewModel)
	{
		InitializeComponent();
        BindingContext = objLoginViewModel;
    }
    protected override bool OnBackButtonPressed()
    {
        return true;
    }
}
