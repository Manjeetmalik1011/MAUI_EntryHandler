using System;
using MAUIHandlers.Application.Services.Identity;
using MAUIHandlers.Application.Services.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace MAUIHandlers.Application.ViewModels
{
	public class LoadingViewModel : BaseViewModel
    {
        private readonly IIdentityService identityService;

        public LoadingViewModel(IRoutingService routingService = null, IIdentityService identityService = null)
        {
            this.NavigationService = routingService;
            this.identityService = identityService;
        }

        // Called by the views OnAppearing method
        public async void Init()
        {
            var isAuthenticated = await this.identityService.VerifyRegistration();
            if (isAuthenticated)
            {
                await this.NavigationService.NavigateTo("///main");
            }
            else
            {
                await this.NavigationService.NavigateTo("///login");
            }
        }
    }
}

