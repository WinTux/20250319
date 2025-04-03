using CommunityToolkit.Maui.Views;
using CommunityToolkit.Maui.Core.Primitives;

namespace EjemplosMAUI.Paginas;

public partial class ImagenAudioPage : ContentPage
{
	public ImagenAudioPage()
	{
		InitializeComponent();
        lblInfoFlash.Text = camara.CameraFlashMode == CameraFlashMode.On ? "Flash activado" : "Flash desactivado";

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
    async void OnTomarFotoToolkitClic(object sender, MediaCapturedEventArgs e)
    {
        Dispatcher.Dispatch(() => {
            foto.Source = ImageSource.FromStream(() => e.Media);
            return;
        });
    }
    async void OnTomarFotoToolkitBtnClic(object sender, EventArgs e) {
        await camara.CaptureImage(CancellationToken.None);
    }
    async void OnZoomInClic(object sender, EventArgs e)
    {
        camara.ZoomFactor += 0.1f;
    }
    async void OnZoomOutClic(object sender, EventArgs e)
    {
        camara.ZoomFactor -= 0.1f;
    }
    async void OnFlashClic(object sender, EventArgs e)
    {
        camara.CameraFlashMode = camara.CameraFlashMode == CameraFlashMode.On? CameraFlashMode.Off : CameraFlashMode.On;
        lblInfoFlash.Text = camara.CameraFlashMode == CameraFlashMode.On ? "Flash activado" : "Flash desactivado";
    }
}