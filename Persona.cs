using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3A2
{
    internal class Persona
    {
        private string nombre;
        private Domicilio domicilio;
        private Televisor tv;
        private string v;
       

        public Persona(string v, Domicilio domicilio, Televisor tv)
        {
            this.v = v;
            this.domicilio = domicilio;
            this.tv = tv;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Domicilio Domicilio { get => domicilio; set => domicilio = value; }
        internal Televisor Tv { get => tv; set => tv = value; }

        public override string ToString()
        {
            return ($"Nombre: {Nombre}, Domicilio {domicilio}, Tv {Tv}");
        }



    }
}
