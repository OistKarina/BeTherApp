using Microsoft.Extensions.Logging;
using BeTherApp.Services;
using BeTherApp.ViewModels;
using BeTherApp.View;
//using Android.SE.Omapi;

namespace BeTherApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<BaseService>();
        builder.Services.AddSingleton<ConnectToAppService>();
        builder.Services.AddSingleton<ConnectToAppViewModle>();
        builder.Services.AddSingleton<LoginPage>();



#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}

