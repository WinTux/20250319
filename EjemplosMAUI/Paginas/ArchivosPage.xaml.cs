namespace EjemplosMAUI.Paginas;

public partial class ArchivosPage : ContentPage
{
	public ArchivosPage()
	{
		InitializeComponent();
	}
	async void OnCargarImagenClic(object sender, EventArgs e)
    {
        var resultado = await FilePicker.PickAsync(
            new PickOptions{
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Selecciona una imagen"
            });
        if (resultado != null)
        {
            var stream = await resultado.OpenReadAsync();
            imagen.Source = ImageSource.FromStream(() => stream);
        }
        else return;// Por si no se selecciona nada
    }
    async void OnCargarImagenesClic(object sender, EventArgs e)
    {
        var resultados = await FilePicker.PickMultipleAsync(
            new PickOptions
            {
                FileTypes = FilePickerFileType.Images,
                PickerTitle = "Selecciona tus imagenes"
            });
        if (resultados != null)
        {
            foreach (var resultado in resultados)
            {
                await DisplayAlert("Imagen seleccionada", resultado.FileName, "Aceptar");
                /*
                var stream = await resultado.OpenReadAsync();
                var imagen = new Image
                {
                    Source = ImageSource.FromStream(() => stream),
                    WidthRequest = 50,
                    HeightRequest = 50
                };
                contenedor.Children.Add(imagen);
                */
            }
        }
        else return;
    }
    async void OnCargarPersonalizadoClic(object sender, EventArgs e)
    {
        var tipoPersonalizado = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
        {
            { DevicePlatform.Android, new[] { "application/pdf" } },
            { DevicePlatform.iOS, new[] { "com.adobe.pdf" } }, // public.pdf
            { DevicePlatform.UWP, new[] { ".pdf" } },
            { DevicePlatform.macOS, new[] { "pdf" } },
            { DevicePlatform.Tizen, new[] { "*/*" } }
        });

        var resultados = await FilePicker.PickMultipleAsync(
            new PickOptions
            {
                FileTypes = tipoPersonalizado,
                PickerTitle = "Selecciona documentos *.pdf"
            });
        if (resultados != null)
        {
            foreach (var resultado in resultados)
                await DisplayAlert("pdf seleccionado", resultado.FileName, "Ok");
        }
        // Por si no se selecciona nada
    }
}