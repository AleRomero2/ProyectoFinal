using MonkeyCache.FileStore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CarMag.Model;
using Xamarin.Essentials;

namespace CarMag.Service
{
    public class CacheService
    {
        public CacheService()
        {
            Barrel.ApplicationId = "CarMagCacheData";
        }

        public async Task<T> SaveAsync<T>(List<T> lista, int days = 1, bool forceRefresh = true)
        {
            try
            {
                Barrel.Current.Add(typeof(T).Name, lista, TimeSpan.FromDays(days));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No ha sido posible guardar en cache {ex}");
            }
            return default(T);
        }
        public List<T> GetAsync<T>()
        {
            List<T> resultado = new List<T>();
            try
            {
                resultado = Barrel.Current.Get<List<T>>(typeof(T).Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"No ha sido posible obtener la cache {ex}");
            }
            return resultado;
        }
    }
}
