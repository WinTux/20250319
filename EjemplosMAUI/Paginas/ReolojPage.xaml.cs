using System.Timers;

namespace EjemplosMAUI.Paginas;

public partial class ReolojPage : ContentPage
{
	public ReolojPage()
	{
		InitializeComponent();
		var temporizador = new System.Timers.Timer(1000);
        temporizador.Elapsed +=new System.Timers.ElapsedEventHandler(redibujarReloj);
        temporizador.Start();
    }

    private void redibujarReloj(object? sender, ElapsedEventArgs e)
    {
        var graphicsView = this.relojGraphicsView;
        graphicsView.Invalidate();
    }
}