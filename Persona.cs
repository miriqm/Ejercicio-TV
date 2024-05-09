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
        Televisor tv;

        public Persona(string nombre, Domicilio domicilio, Televisor tv)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.tv = tv;
        }

        public override string ToString()
        {
            return ($"Nombre: {nombre}, Domicilio {domicilio}");
        }



    }
}
