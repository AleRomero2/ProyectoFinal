using CarMag.Model;
using Java.Lang;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CarMag.Service
{
    public class HttpService : IHttpService
    {
        const string urll= "http://192.168.31.235:9090/cliente/add";
        public HttpService()
        {
        }
        
        public async Task<bool> httpAuth(string email,string password)
        {
            //Cliente cliente = null;
            Cliente clienteBuscar = new Cliente(0, "", password, email);
            bool login=false;
            string cont = JsonConvert.SerializeObject(clienteBuscar);
            var content= new StringContent(cont);
            content.Headers.ContentType =new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            var url = "http://192.168.31.235:9090/Auth/login";
            try
            {
                HttpResponseMessage resp2 = await client.PostAsync(url,content);
                if (resp2.IsSuccessStatusCode)
                {
                    login = true;
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error ", e.Message);
                login = false;
            }
            return login;
        }

        public async Task httpRegister(string usuario,string email, string password,string consumo,string carburante)
        {
            Cliente clienteBuscar = new Cliente(0, usuario, password, email);
            string cont = JsonConvert.SerializeObject(clienteBuscar);
            var content = new StringContent(cont);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var client = new HttpClient();
            try
            {
                HttpResponseMessage resp2 = await client.PostAsync(urll, content);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error ", e.Message);
            }
            await httpAddCar(consumo, carburante, email);
        }

        public async Task httpAddCar(string consumo, string carburante, string email)
        {
            Cliente emailFound=null;
            List<Cliente> Lcliente = new List<Cliente>();
            Lcliente = await httpGet();
            for(int i = 0; i < Lcliente.Count; i++)
            {
                if (Lcliente[i].email.Equals(email))
                {
                    emailFound =Lcliente[i];
                }
            }

            Vehiculo vehiculoRegister = new Vehiculo(0, consumo, carburante, emailFound);
            string objSerialized = JsonConvert.SerializeObject(vehiculoRegister);
            var contentt = new StringContent(objSerialized);
            contentt.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            var cliente = new HttpClient();
            var url = "http://192.168.31.235:9090/vehiculo/add";
            try
            {
                HttpResponseMessage resp2 = await cliente.PostAsync(url, contentt);
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error ", e.Message);
            }
        }
        //get de todos los clientes
        public async Task<List<Cliente>> httpGet()
        {
            var client = new HttpClient();
            var url = "http://192.168.31.235:9090/cliente/";
            var resp2 = await client.GetStringAsync(url);
            List<Cliente> Lcliente = JsonConvert.DeserializeObject<List<Cliente>>(resp2);
            return Lcliente;
        }
        public async Task<Cliente> httpGetClienteByEmail()
        {
            var client = new HttpClient();
            var url = "http://192.168.31.235:9090/cliente/findbycliente";
            var resp2 = await client.GetStringAsync(url);
            Cliente Lcliente = JsonConvert.DeserializeObject<Cliente>(resp2);
            return Lcliente;
        }

    }
}
