using CommunityToolkit.Maui;

namespace Chatter;

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
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
            });

        //xmlns:toolkit="http://schemas.microsoft.com/dotnet/2022/maui/toolkit"
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder.Services.AddMemoryCache();
        builder.Services.AddSingleton<ChatRoomsPage>();
        builder.Services.AddSingleton<ChatRoomsViewModel>();

        builder.Services.AddSingleton<AccountPage>();
        builder.Services.AddTransient<AccountPageViewModel>();

        return builder.Build();
    }
}
