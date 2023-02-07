using System;
using System.Windows.Input;
using MAUIHandlers.Application.Services.Routing;

namespace MAUIHandlers.Application.ViewModels
{
	public class RegistrationViewModel : BaseViewModel
    {

        public RegistrationViewModel(IRoutingService navigationService = null)
        {
            NavigationService = navigationService;
            ExecuteBack = new Command(() => Back());
            ExecuteRegistration = new Command(() => Register());
        }

        public string Name { get; set; }
        public string Firstname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICommand ExecuteBack { get; set; }
        public ICommand ExecuteRegistration { get; set; }

        private async void Back()
        {
            await NavigationService.GoBack();
        }

        private async void Register()
        {
            await NavigationService.NavigateTo("//main");
        }
    }
}

