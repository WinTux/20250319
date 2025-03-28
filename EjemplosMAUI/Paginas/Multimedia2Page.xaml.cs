using CommunityToolkit.Maui.Core.Primitives;

namespace EjemplosMAUI.Paginas;

public partial class Multimedia2Page : ContentPage
{
	public Multimedia2Page()
	{
		InitializeComponent();

	}
    public void OnPlayPauseClic(object sender, EventArgs e)
    {
        if (video.CurrentState == MediaElementState.Playing)
            video.Pause();
        else
            video.Play();
    }
    public void OnValueChangedClic(object sender, ValueChangedEventArgs e)
    {
        video.Volume = e.NewValue;
    }
    public void OnVideoOpened(object sender, EventArgs e)
    {
        posicionSlider.Maximum = video.Duration.TotalSeconds;
    }
    public void OnValueChangedPosicionClic(object sender, ValueChangedEventArgs e)
    {
        Dispatcher.DispatchAsync(() =>
        {
            video.SeekTo(TimeSpan.FromSeconds(e.NewValue));
        });
    }
    public void OnPosicionCambiada(object sender,MediaPositionChangedEventArgs e)
    {
        Dispatcher.DispatchAsync(() =>
        {
            posicionSlider.Value = e.Position.TotalSeconds;
        });
    }
    public void OnValueChangedmp3Clic(object sender, ValueChangedEventArgs e)
    {
        audio.Volume = e.NewValue;
    }
}