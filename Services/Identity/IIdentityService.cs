using System;
namespace MAUIHandlers.Application.Services.Identity
{
    public interface IIdentityService
    {
        Task<bool> VerifyRegistration();
        Task Authenticate();
    }
}

