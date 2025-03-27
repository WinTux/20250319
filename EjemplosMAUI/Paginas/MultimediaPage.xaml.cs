using CommunityToolkit.Maui.Core.Primitives;

namespace EjemplosMAUI.Paginas;

public partial class MultimediaPage : ContentPage
{
	public MultimediaPage()
	{
		InitializeComponent();
	}
	public void OnPlayPauseClic(object sender, EventArgs e)
    {
        if (video4.CurrentState == MediaElementState.Playing)
            video4.Pause();
        else
            video4.Play();
    }
}