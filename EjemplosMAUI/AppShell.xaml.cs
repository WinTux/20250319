namespace EjemplosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Paginas.ReolojPage), typeof(Paginas.ReolojPage));
            Routing.RegisterRoute(nameof(Paginas.ScannerQRPage), typeof(Paginas.ScannerQRPage));
            Routing.RegisterRoute(nameof(Paginas.DrawingPage), typeof(Paginas.DrawingPage));
            Routing.RegisterRoute(nameof(Paginas.MapaPage), typeof(Paginas.MapaPage));
            Routing.RegisterRoute(nameof(Paginas.MultimediaPage), typeof(Paginas.MultimediaPage));
            Routing.RegisterRoute(nameof(Paginas.Multimedia2Page), typeof(Paginas.Multimedia2Page));
            Routing.RegisterRoute(nameof(Paginas.GridPage), typeof(Paginas.GridPage));
            Routing.RegisterRoute(nameof(Paginas.Grid2Page), typeof(Paginas.Grid2Page));
            Routing.RegisterRoute(nameof(Paginas.ArchivosPage), typeof(Paginas.ArchivosPage));
            Routing.RegisterRoute(nameof(Paginas.ImagenAudioPage), typeof(Paginas.ImagenAudioPage));
        }
    }
}
