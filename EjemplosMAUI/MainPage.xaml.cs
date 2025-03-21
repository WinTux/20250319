using EjemplosMAUI.Paginas;

namespace EjemplosMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnEjemplo1Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ReolojPage));
        }
    }

}
