
using MAUIHandlers.Application.Services.Identity;
using MAUIHandlers.Application.Services.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace MAUIHandlers.Application;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .RegisterAppServices()
            .RegisterViews()
            .RegisterViewModels()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        CommonUtility.HandlerUtility.ModifyEntry();
		#if DEBUG
				builder.Logging.AddDebug();
		#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<ViewModels.LoadingViewModel>();
        mauiAppBuilder.Services.AddTransient<ViewModels.LoginViewModel>();
        mauiAppBuilder.Services.AddTransient<ViewModels.RegistrationViewModel>();
        mauiAppBuilder.Services.AddTransient<ViewModels.AboutViewModel>();
        mauiAppBuilder.Services.AddTransient<ViewModels.ItemsViewModel>();
        mauiAppBuilder.Services.AddTransient<ViewModels.ItemDetailViewModel>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<IRoutingService, ShellRoutingService>();
        mauiAppBuilder.Services.AddSingleton<IIdentityService, IdentityServiceStub>();
        return mauiAppBuilder;
    }

    private static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<AppShell>();
        mauiAppBuilder.Services.AddTransient<Views.LoadingPage>();
        mauiAppBuilder.Services.AddTransient<Views.LoginPage>();
        mauiAppBuilder.Services.AddTransient<Views.RegistrationPage>();
        mauiAppBuilder.Services.AddTransient<Views.AboutPage>();
        mauiAppBuilder.Services.AddTransient<Views.ItemsPage>();
        mauiAppBuilder.Services.AddTransient<Views.ItemDetailPage>();
        return mauiAppBuilder;
    }

}

