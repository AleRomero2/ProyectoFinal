using CarMag.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarMag.Service
{
    public class HttpService
    {
        public HttpService()
        {
        }

        public static async Task<List<Cliente>> httpGet()
        {
            var client = new HttpClient();
            var url = "http://10.0.2.2:9090/cliente/";
            var resp2 = await client.GetStringAsync(url);
            List<Cliente> Lcliente = JsonConvert.DeserializeObject<List<Cliente>>(resp2);
            return Lcliente;
        }
    }
}
