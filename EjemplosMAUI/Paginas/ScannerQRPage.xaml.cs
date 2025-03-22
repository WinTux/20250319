using ZXing.Net.Maui;

namespace EjemplosMAUI.Paginas;

public partial class ScannerQRPage : ContentPage
{
	public ScannerQRPage()
	{
		InitializeComponent();
        lectorCodigo.Options = new BarcodeReaderOptions()
        {
            AutoRotate = true,
            Formats = BarcodeFormats.All,//BarcodeFormat.QrCode,
            TryHarder = true,
            Multiple = false
        };

    }
	async void OnCodigoBarrasDetectado(object sender, BarcodeDetectionEventArgs e)
    {
		Dispatcher.Dispatch(() => {
            //await DisplayAlert("Código de barras detectado", e.Result.Text, "Aceptar");
            resultadoCodigo.Text = $"Texto: {e.Results[0].Value}; Formato: {e.Results[0].Format}";
        });
    }
}