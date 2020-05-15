using CarMag.Model;
using CarMag.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarMag.ViewModel
{
    class Page1ViewModel : BindableObject
    {
        public static List<Cliente> Lcliente;
        IHttpService peticion = new HttpService();
        public Page1ViewModel()
        {
           // ApiCall();
        }
        /*private static async void ApiCall()
        {
           // Lcliente = await peticion.httpGet();
        }*/

        public List<Cliente> Lclientes
        {
            get => Lcliente;
            set
            {
                Lcliente = value;
                OnPropertyChanged();
            }
        }
    }
}
