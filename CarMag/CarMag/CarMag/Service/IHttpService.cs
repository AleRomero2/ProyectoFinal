using System.Collections.Generic;
using System.Threading.Tasks;
using CarMag.Model;

namespace CarMag.Service
{
    public interface IHttpService
    {
        Task<List<Cliente>> httpGet();
    }
}