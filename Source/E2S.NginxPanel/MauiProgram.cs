using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace E2S.NginxPanel
{
    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

#if WINDOWS
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#elif ANDROID
            builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
