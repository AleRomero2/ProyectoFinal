using Java.Sql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    class Gasto
    {
        public Gasto(long id, string titulo, string tipoGasto, Date fecha, string motivo, Cliente cliente)
        {
            this.id = id;
            this.titulo = titulo;
            this.tipoGasto = tipoGasto;
            this.fecha = fecha;
            this.motivo = motivo;
            this.cliente_id = cliente;
        }

        public long id { get; set; }
        public string titulo { get; set; }
        public string tipoGasto { get; set; }
        public Date fecha { get; set; }
        public string motivo { get; set; }
        public Cliente cliente_id { get; set; }
    }
}
