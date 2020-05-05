using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkiaSharp;
using Microcharts;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMag.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoricoView : ContentPage
    {
        public HistoricoView()
        {
            InitializeComponent();
            BindingContext = new ViewModel.DisplayChartViewModel();
        }
    }
}