using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    class Trayecto
    {
        public long id { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        //private Date fecha;
        public string motivo { get; set; }
        public Cliente cliente { get; set; }

        public Trayecto(long id, string origen, string destino, string motivo, Cliente cliente)
        {
            this.id = id;
            this.origen = origen;
            this.destino = destino;
            this.motivo = motivo;
            this.cliente = cliente;
        }
    }
}
