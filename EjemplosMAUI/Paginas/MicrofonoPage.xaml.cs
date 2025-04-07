using Plugin.Maui.Audio;

namespace EjemplosMAUI.Paginas;

public partial class MicrofonoPage : ContentPage
{
	private readonly IAudioManager audioManager;
    private readonly IAudioRecorder audioRecorder;
    public MicrofonoPage(IAudioManager audioManager)
	{
		InitializeComponent();
		this.audioManager = audioManager;
		this.audioRecorder = audioManager.CreateRecorder();
	}
	private async void OnGrabarClic(object sender, EventArgs e) {
		if (await Permissions.RequestAsync<Permissions.Microphone>() != PermissionStatus.Granted)
			return;
		if (audioRecorder.IsRecording)
		{
			var audioGrabado = await audioRecorder.StopAsync();
            GrabarBtn.Text = "Grabar";
			var reproductor = AudioManager.Current.CreatePlayer(audioGrabado.GetAudioStream());
			reproductor.Play();
		}
		else { 
			audioRecorder.StartAsync();
            GrabarBtn.Text = "Detener";
        }

    }
}