using System;
namespace MAUIHandlers.Application.Services.Routing
{
    public interface IRoutingService
    {
        Task GoBack();
        Task GoBackModal();
        Task NavigateTo(string route);
    }
}

