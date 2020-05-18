using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CarMag.Model;
using CarMag.Service;
using CarMag.ViewModel.Base;
using Microcharts;
using SkiaSharp;
namespace CarMag.ViewModel
{
    public class DisplayChartViewModel:BaseViewModel
    {
        Cliente clienteLo = new Cliente();
        CacheService cache = new CacheService();
        IHttpService peticion = new HttpService();
        List<Gasto> lgasto = new List<Gasto>();
        List<Gasto> lgastoCliente = new List<Gasto>();
        int cuantia = new int();
        public DisplayChartViewModel()
        {
            List<Cliente> lista = cache.GetAsync<Cliente>();
            clienteLo = lista[0];
            traeGastosAsync();
        }
        public async System.Threading.Tasks.Task traeGastosAsync()
        {
            lgasto = await peticion.httpGetGasto();
            lgastoCliente = lgasto.Where<Gasto>(a=> a.cliente_id.id.Equals(clienteLo.id)).ToList();
            foreach (Gasto a in lgastoCliente) {
                int cuanti = int.Parse(a.cuantia);
                Cuantia =Cuantia+ cuanti;
            }
        }
        public int Cuantia 
        {
            get { return cuantia; }
            set
            {
                cuantia = value;
                OnPropertyChanged();
            }
        }

        public Chart RadielGaugeChartSample => new RadialGaugeChart()
        {
            
            Entries = new[]
            {
                new Entry(100)
                {
                    Color = SKColor.Parse("#ff80ff"),
                    TextColor = SKColor.Parse("#ff80ff"),
                    Label = "Gasolina",
                    ValueLabel = Cuantia.ToString()
                },
                new Entry(Cuantia)
                {
                    Color = SKColor.Parse("#A8F4B4"),
                    TextColor = SKColor.Parse("#A8F4B4"),
                    Label = Cuantia.ToString(),
                    ValueLabel = Cuantia.ToString(),
                },
                new Entry(Cuantia)
                {
                    Color = SKColor.Parse("#B7A8F4"),
                    TextColor = SKColor.Parse("#B7A8F4"),
                    Label = "Servicios",
                    ValueLabel = "25%"
                },
            },
            LineSize = 30,
            LabelTextSize = 50,
        };
    }
}
