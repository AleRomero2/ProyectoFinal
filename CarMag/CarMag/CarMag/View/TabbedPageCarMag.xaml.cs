using CarMag.Model;
using CarMag.Service;
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
    public partial class TabbedPageCarMag : TabbedPage
    {

         public TabbedPageCarMag(IHttpService peticion)
        {
            InitializeComponent();

        }
        
    }
}