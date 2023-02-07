using System;
using System.Windows.Input;
using MAUIHandlers.Application.Services.Routing;

namespace MAUIHandlers.Application.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(IRoutingService navigationService = null)
        {
            NavigationService = navigationService;
            ExecuteLogin = new Command(() => Login());
            ExecuteRegistration = new Command(() => Register());
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public ICommand ExecuteLogin { get; set; }
        public ICommand ExecuteRegistration { get; set; }

        private void Login()
        {
            // This is where you would probably check the login and only if valid do the navigation...
            NavigationService.NavigateTo("///main/home");
        }

        private void Register()
        {
            Shell.Current.GoToAsync("//login/registration");
        }
    }
}

