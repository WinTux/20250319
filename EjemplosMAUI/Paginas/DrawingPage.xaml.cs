using CommunityToolkit.Maui.Core;

namespace EjemplosMAUI.Paginas;

public partial class DrawingPage : ContentPage
{
	public DrawingPage()
	{
		InitializeComponent();
	}
	async void OnLineaDibujada(object sender, DrawingLineCompletedEventArgs e) {
		var stream = await lienzo.GetImageStream(200, 200);
		Dispatcher.DispatchAsync(() =>
        {
            imagenGenerada.Source = ImageSource.FromStream(() => stream);
        });
    }
}