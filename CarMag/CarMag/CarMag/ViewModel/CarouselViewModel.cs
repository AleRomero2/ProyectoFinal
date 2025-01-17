﻿using CarMag.Model;
using CarMag.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    public class CarouselViewModel : BindableObject
    {
        private Command _SkipButtonCommand;
        public ICommand SkipButtonCommand => _SkipButtonCommand;
        private ObservableCollection<ItemsCarousel> items = new ObservableCollection<ItemsCarousel>();
        ItemsCarousel item1 = new ItemsCarousel("0", "Bienvenido a CarMag", "baseline_directions_car_black_48.png");
        ItemsCarousel item2 = new ItemsCarousel("0", "Gestiona los gastos de tus viajes o trayectos", "baseline_local_gas_station_black_48.png");
        ItemsCarousel item3 = new ItemsCarousel("0", "Recuerda y gestiona el mantenimiento de tu vehiculo", "baseline_build_black_48.png");
        public CarouselViewModel()
        {
            LoadItems();
            _SkipButtonCommand = new Command(SkipButtonComman);
        }
        private void SkipButtonComman()
        {
            //App.Current.MainPage.Navigation.PushAsync(new TabbedPageCarMag("ale@gmail.com"));
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
