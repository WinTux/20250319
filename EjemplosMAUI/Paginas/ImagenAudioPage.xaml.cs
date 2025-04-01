namespace EjemplosMAUI.Paginas;

public partial class ImagenAudioPage : ContentPage
{
	public ImagenAudioPage()
	{
		InitializeComponent();
	}
	async void OnTomarFotoClic(object sender, EventArgs e)
    {
        var resultado = await MediaPicker.CapturePhotoAsync();
        if (resultado != null)
        {
            var flujoFoto = await resultado.OpenReadAsync();
            foto.Source = ImageSource.FromStream(() => flujoFoto);
        }
    }
    async void OnTomarFotoToolkitClic(object sender, EventArgs e)
    {
        
    }
}