using Java.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    public class Gasto
    {
        public Gasto(long id, string titulo, string tipoGasto, string motivo,string cuantia,Cliente cliente_id)
        {
            this.id = id;
            this.titulo = titulo;
            this.tipoGasto = tipoGasto;
            //this.fecha = fecha;
            this.motivo = motivo;
            this.cuantia = cuantia;
            this.cliente_id = cliente_id;
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
