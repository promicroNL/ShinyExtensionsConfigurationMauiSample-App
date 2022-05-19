using Microsoft.Extensions.Configuration;

namespace MauiApp3;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var config = new ConfigurationBuilder()
            .AddJsonPlatformBundle("appsettings.json")
            .AddPlatformPreferences()
            .Build();

        var builder = MauiApp.CreateBuilder();

        builder.Configuration.AddConfiguration(config);

        builder.Services.AddSingleton<MainPage>();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
