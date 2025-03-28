using CommunityToolkit.Maui;
using EjemplosMAUI.Paginas;
using Microsoft.Extensions.Logging;
using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace EjemplosMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCommunityToolkitMediaElement()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.UseMauiMaps();
            builder.UseBarcodeReader()
                .ConfigureMauiHandlers(h => {
                    h.AddHandler(typeof(CameraBarcodeReaderView), typeof(CameraBarcodeReaderViewHandler));
                    h.AddHandler(typeof(CameraView), typeof(CameraViewHandler));
                    h.AddHandler(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView), typeof(BarcodeGeneratorViewHandler));
                });
            builder.Services.AddTransient<ReolojPage>();
            builder.Services.AddTransient<ScannerQRPage>();
            builder.Services.AddTransient<DrawingPage>();
            builder.Services.AddTransient<MapaPage>();
            builder.Services.AddTransient<MultimediaPage>();
            builder.Services.AddTransient<Multimedia2Page>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
