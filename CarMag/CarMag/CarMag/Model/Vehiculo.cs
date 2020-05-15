using Java.Lang;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    class Vehiculo
    {
        public long id { get; set; }
        public string consumo { get; set; }
        public string carburante { get; set; }
        public Cliente cliente_id { get; set; }
        public Vehiculo(long id,string consumo,string carburante, Cliente clientid)
        {
            this.id = id;
            this.consumo = consumo;
            this.carburante = carburante;
            this.cliente_id = clientid;
        }
    }
}
