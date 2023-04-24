using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short _cilindrada;
        
        public short Cilindrada
        {
            get { return _cilindrada; }
            set { _cilindrada = value; }
        }

        public MotoCross(short numero, string escuderia) : base(numero, escuderia) { }

        public MotoCross(short numero, string escuderia, short cilindrada) : base(numero, escuderia)
        {
            Cilindrada = cilindrada;
            Cilindrada = cilindrada;
        }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if(a1.Numero == a2.Numero &&
                a1.Escuderia == a2.Escuderia &&
                a1.Cilindrada == a2.Cilindrada)
            {
                return true;
            }
            return false; 
        }
        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
