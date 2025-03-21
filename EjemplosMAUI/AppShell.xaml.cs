namespace EjemplosMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Paginas.ReolojPage), typeof(Paginas.ReolojPage));
            Routing.RegisterRoute(nameof(Paginas.ScannerQRPage), typeof(Paginas.ScannerQRPage));
        }
    }
}
