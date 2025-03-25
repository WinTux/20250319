using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace EjemplosMAUI.Paginas;

public partial class MapaPage : ContentPage
{
	public MapaPage()
	{
		InitializeComponent();
        //Map mapa = new Map();
        //Content = mapa;

        // Cambiar ubicación inicial de manera programática
        /*
        Location ubicacion = new Location(-16.50167082361847, -68.13270390384872);
        MapSpan region = new MapSpan(ubicacion, 0.01, 0.01);
        miMapa.MoveToRegion(region);
        */

        // Poniendo un  pin
        miMapa.Pins.Add(new Pin
        {
            Label = "EDUCOMSER S.R.L.",
            Address = "Av. 16 de Julio",
            Type = PinType.Place,
            Location = new Location(-16.501035824231536, -68.1334916223872)
        });
    }
}