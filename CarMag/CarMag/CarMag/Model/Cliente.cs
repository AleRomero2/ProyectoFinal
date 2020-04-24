using System;
using System.Collections.Generic;
using System.Text;

namespace CarMag.Model
{
    public class Cliente
    {
        protected long Id { get; set; }
        protected string nombre { get; set; }
        protected string psw { get; set; }

        public override string ToString()
        {
            return "Cliente: " + Id +" " +nombre + " " + psw;
        }
    }
}
