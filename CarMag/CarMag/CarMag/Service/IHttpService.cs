using CarMag.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarMag.Service
{
    interface IHttpService
    {
        Task<List<Cliente>> httpGet();
        Task<bool> httpAuth(string email, string password);
        Task httpRegister(string usuario, string email, string password, string consumo, string carburante);
        Task httpAddCar(string consumo, string carburante,string email);
        Task<Cliente> httpGetClienteByEmail();
    }
}
