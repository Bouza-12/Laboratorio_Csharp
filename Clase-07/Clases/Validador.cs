using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class Validador
    {
        public static int ValidarDniOrThrow(int dni)
        {
            if (dni < 0)
            {
                throw new ArgumentException("Numero de DNI inválido");
            }
            return dni;
        }

        public static int ValidarLegajoOrThrow(int legajo)
        {
            if (legajo < 100000)
            {
                throw new ArgumentException("Numero de legajo inválido");
            }
            return legajo;
        }
    }
}
