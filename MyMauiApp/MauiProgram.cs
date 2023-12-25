using Microsoft.Extensions.Logging;
using MyMauiApp.Pages;
using Shared.Services;

namespace MyMauiApp
{
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
              builder.Services.AddSingleton<ProductAddPage>();
              builder.Services.AddSingleton<ProductListPage>();
            builder.Services.AddSingleton<ProductService>();

            return builder.Build();
        }
    }
}
