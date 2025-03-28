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
        }
    }
}
