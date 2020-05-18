using CarMag.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMag.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServicioView : ContentPage
    {
        public ServicioView()
        {
            InitializeComponent();
            BindingContext = new MantenimientoViewModel();
        }
    }
}