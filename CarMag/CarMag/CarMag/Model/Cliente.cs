using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    public class Cliente
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string psw { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "Cliente: " + id +" " +nombre + " " + psw;
        }
        public Cliente(string email,string psw)
        {
            this.email = email;
            this.psw = psw;
        }

        public Cliente(long id, string nombre, string psw, string email)
        {
            this.id = id;
            this.nombre = nombre;
            this.psw = psw;
            this.email = email;
        }

        public Cliente()
        {
        }
    }
}
