using CarMag.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMag.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioCarouselV : ContentPage
    {
        public InicioCarouselV()
        {
            InitializeComponent();
            BindingContext = new CarouselViewModel();
        }

    }
}