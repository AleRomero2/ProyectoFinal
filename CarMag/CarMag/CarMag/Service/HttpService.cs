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
        
        public static async Task<Boolean> httpAuth(string email,string password)
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
            catch (Exception e)
            {
                Console.WriteLine("Error ", e.Message);
                login = false;
            }
            return login;
        }
        /*public static async Task<Boolean> httpAuth2(string email, string password)
        {
            //Cliente cliente = null;
            Cliente clienteBuscar = new Cliente(0, "", password, email);
            bool login = false;
            var content = new StringContent(JsonConvert.SerializeObject(clienteBuscar));
            var client = new HttpClient();
            var url = "http://localhost:9090/Auth/login";
            try
            {
                var clientes = new Cliente(0, "", password, email) { };
                Task<HttpResponseMessage> postTask = await client.PostAsync(url, clientes);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    login = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ", e.Message);
                login = false;
            }
            return login;
        }*/

        public static async Task<List<Cliente>> httpGet()
        {
            var client = new HttpClient();
            var url = "http://10.0.2.2:9090/cliente/";
            var resp2 = await client.GetStringAsync(url);
            List<Cliente> Lcliente = JsonConvert.DeserializeObject<List<Cliente>>(resp2);
            return Lcliente;
        }
        public static async Task<Cliente> httpGett(string email, string password)
        {
            Cliente cliente = null;
            var client = new HttpClient();
            var url = "http://10.0.2.2:9090/Auth/login";
            try
            {
                HttpResponseMessage resp2 = await client.GetAsync(url);
                if (resp2.IsSuccessStatusCode)
                {
                    string resp = await client.GetStringAsync(url);
                    cliente = JsonConvert.DeserializeObject<Cliente>(resp);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error ", e.Message);
            }
            return cliente;
        }
    }
}
