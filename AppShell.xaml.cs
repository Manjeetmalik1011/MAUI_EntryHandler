using System.Windows.Input;
using MAUIHandlers.Application.Views;

namespace MAUIHandlers.Application;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("registration", typeof(RegistrationPage));
        Routing.RegisterRoute("main/login", typeof(LoginPage));
        BindingContext = this;
    }

    public ICommand ExecuteLogout => new Command(async () => await GoToAsync("main/login"));
}

