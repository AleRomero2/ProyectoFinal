using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    class Mantenimiento
    {
        public long id { get; set; }
        public long odometro { get; set; }
        public string tipo { get; set; }
        public string localizacion { get; set; }
        public Vehiculo vehiculo { get; set; }

        public Mantenimiento(long id, long odometro, string tipo, string localizacion, Vehiculo vehiculo)
        {
            this.id = id;
            this.odometro = odometro;
            this.tipo = tipo;
            this.localizacion = localizacion;
            this.vehiculo = vehiculo;
        }
    }
}
