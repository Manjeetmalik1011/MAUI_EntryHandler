using MAUIHandlers.Application.Services.Identity;

namespace MAUIHandlers.Application;

public partial class App : IApplication
{
	public App()
	{
        InitializeComponent();
		MainPage = new AppShell();
	}
    
}

