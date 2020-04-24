using CarMag.Model;
using CarMag.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarMag.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        //public static List<Cliente> Lcliente = new List<Cliente>();
        public Page1()
        {
            InitializeComponent();
            BindingContext = new Page1ViewModel();
            //ApiCall();
        }
        /*private async void ApiCall()
        {
            Lcliente = await Page1ViewModel.httpGet();
            pswApi =Lcliente[0].psw;
            nameApi =Lcliente[1].nombre;
        }*/

       /* public string NameApi
        {
            get => nameApi;
            set
            {
                nameApi = value;
                OnPropertyChanged();
            }
        }
        public string PswApi
        {
            get => pswApi;
            set
            {
                pswApi = value;
                OnPropertyChanged();
            }
        }*/
        /*public List<Cliente> Lclientes
        {
            get => Lcliente;
            set
            {
                Lcliente = value;
                OnPropertyChanged();
            }
        }*/
    }
}