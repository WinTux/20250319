﻿using EjemplosMAUI.Paginas;

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
        private async void OnEjemplo2Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ScannerQRPage));
        }
        private async void OnEjemplo3Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(DrawingPage));
        }
        private async void OnEjemplo4Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MapaPage));
        }
        private async void OnEjemplo5Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MultimediaPage));
        }
        private async void OnEjemplo6Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Multimedia2Page));
        }
        private async void OnEjemplo7Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GridPage));
        }
        private async void OnEjemplo8Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Grid2Page));
        }
        private async void OnEjemplo9Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ArchivosPage));
        }
        private async void OnEjemplo10Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ImagenAudioPage));
        }
        private async void OnEjemplo11Clic(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MicrofonoPage));
        }
    }

}
