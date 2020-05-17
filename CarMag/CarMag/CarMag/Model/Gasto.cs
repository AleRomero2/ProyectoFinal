using Java.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    class Gasto
    {
        public Gasto(long id, string titulo, string tipoGasto, string motivo,string cuantia)
        {
            this.id = id;
            this.titulo = titulo;
            this.tipoGasto = tipoGasto;
            //this.fecha = fecha;
            this.motivo = motivo;
            this.cuantia = cuantia;
            //this.cliente_id = clientid;
        }

        public long id { get; set; }
        public string titulo { get; set; }
        public string tipoGasto { get; set; }
        public string cuantia { get; set; }
        //public Date fecha { get; set; }
        public string motivo { get; set; }
        public Cliente cliente_id { get; set; }
    }
}
