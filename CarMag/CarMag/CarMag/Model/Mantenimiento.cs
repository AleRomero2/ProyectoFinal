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
        public string cuantia { get; set; }
        public Vehiculo vehiculo { get; set; }

        public Mantenimiento(long id, long odometro, string tipo, string localizacion, string cuantia, Vehiculo vehiculo)
        {
            this.id = id;
            this.odometro = odometro;
            this.tipo = tipo;
            this.localizacion = localizacion;
            this.cuantia = cuantia;
            this.vehiculo = vehiculo;
        }
    }
}
