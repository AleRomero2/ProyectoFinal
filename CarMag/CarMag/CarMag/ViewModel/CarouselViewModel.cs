using CarMag.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    public class CarouselViewModel : BindableObject
    {
        private ObservableCollection<ItemsCarousel> items = new ObservableCollection<ItemsCarousel>();
        ItemsCarousel item1 = new ItemsCarousel("0", "Bienvenido a CarMag", "coche.png");
        ItemsCarousel item2 = new ItemsCarousel("0", "Gestiona los gastos de tus viajes o trayectos", "surtidor.png");
        ItemsCarousel item3 = new ItemsCarousel("0", "Recuerda y gestiona el mantenimiento de tu vehiculo", "herramienta.jpg");
        public CarouselViewModel()
        {
            LoadItems();
        }

            public ObservableCollection<ItemsCarousel> Items
            {
                get => items;
                set
                {
                    items = value;
                    OnPropertyChanged();
                }
            }

        private void LoadItems()
        {
            Items.Add(item1);
            Items.Add(item2);
            Items.Add(item3);
        }
    }
    
}
