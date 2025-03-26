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

        // Cambiando tipo de mapa
        //miMapa.MapType = MapType.Hybrid;
    }

    async void OnMapaCLic(object sender, MapClickedEventArgs e) { 
        System.Diagnostics.Debug.WriteLine($"Clic en {e.Location.Latitude}, {e.Location.Longitude}");
        Polygon recuadro = new Polygon
        {
            StrokeWidth = 8,
            StrokeColor = Color.FromArgb("#f4b89f"),
            FillColor = Color.FromArgb("#88c4f4de"),
            Geopath = {
                new Location(-16.500041015284143, -68.13196543870625),
                new Location(-16.50034652387182, -68.13130541908905),
                new Location(-16.50085752227621, -68.13140024949382),
                new Location(-16.500533829493506, -68.13213234021865)
            }
        };
        miMapa.MapElements.Add(recuadro);

        // Agregando un polyline
        Polyline ruta = new Polyline
        {
            StrokeWidth = 15,
            StrokeColor = Color.FromArgb("#809fdbf4"),
            Geopath = {
                new Location(-16.501801577833366, -68.1328569273692),
                new Location(-16.501683278174305, -68.13279523656472),
                new Location(-16.501796434371425, -68.13266380832906),
                new Location(-16.502117900479305, -68.13255383776452),
                new Location(-16.503984965094784, -68.1312395553718),
                new Location(-16.504157269055757, -68.13130392837348),
                new Location(-16.504327001155257, -68.13126637744901),
                new Location(-16.50434243133873, -68.13105448294662),
                new Location(-16.5041444105573, -68.13095524121765),
                new Location(-16.504002967017843, -68.13096328784432),
                new Location(-16.503799802480142, -68.13098206330656),
                new Location(-16.503000000756945, -68.12967046310136),
                new Location(-16.503087439047036, -68.12957122137239)
            }
        };
        miMapa.MapElements.Add(ruta);

        // Agregando un círculo
        Circle circle = new Circle
        {
            Center = new Location(-16.503197120195797, -68.13295648355941),
            Radius = Distance.FromKilometers(0.1),
            StrokeColor = Color.FromArgb("#f4b89f"),
            StrokeWidth = 8,
            FillColor = Color.FromArgb("#88c4f4de")
        };
        miMapa.MapElements.Add(circle);
    }
}