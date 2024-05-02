/* Unmerged change from project 'ABGroupAppv2 (net8.0-android)'
Before:
using DevExpress.Maui;
After:
using Microsoft.Extensions.Logging;
*/
using Microsoft.Extensions.Logging;
using ABGroupAppv2.Platforms;
using Radzen;


namespace ABGroupAppv2
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddRadzenComponents();
            builder.Services.AddTransient<IWordDocumentService, WordDocumentService>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();

            builder.Logging.AddDebug();
#endif
            SecureStorage.RemoveAll();
            return builder.Build();
        }
    }
}
