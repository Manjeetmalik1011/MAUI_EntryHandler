using System;
using System.Windows.Input;
using MAUIHandlers.Application.Services.Routing;

namespace MAUIHandlers.Application.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(IRoutingService navigationService = null)
        {
            Title = "About";

            OpenWebCommand = new Command(() => Browser.Default.OpenAsync(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}

