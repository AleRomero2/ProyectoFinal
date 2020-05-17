using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarMag.ViewModel;

namespace CarMag.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RutaView : ContentPage
    {
        private Position center= new Position(37.3828316, -5.9731698);

        public RutaView()
        {
            InitializeComponent();
            BindingContext = new TrayectoViewModel();
            var posicion1 = new Position(37.356316, -5.981843);
            var posicion2 = new Position(37.371638, -5.999653);
            //Geocoder geocoder = new Geocoder();
            MapSpan localizacion = new MapSpan(center, 37.3828316, -5.9731698);
            MapView.MoveToRegion(localizacion);
            var pin = new Pin
            {
                Type = PinType.SearchResult,
                Position = posicion1,
                Label = "Campo Benito Villamarín"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = posicion2,
                Label = "Fesac"
            };
            MapView.Pins.Add(pin);
            MapView.Pins.Add(pin2);
        }
    }
}