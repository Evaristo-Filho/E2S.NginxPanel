using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace E2S.NginxPanel
{
    public static class MauiProgram
    {

        public static MauiApp CreateMauiApp()
        {


#if WINDOWS
var builder = MauiApp.CreateBuilder();
builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                }).UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
            
#elif ANDROID
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
