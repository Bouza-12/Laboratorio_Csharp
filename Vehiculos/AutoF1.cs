using System.Security.AccessControl;
using System.Text;

namespace Vehiculos
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short _caballosDeFuerza;

        public short CaballosDeFuerza
        {
            get { return _caballosDeFuerza; }
            set { _caballosDeFuerza = value; }
        }
        public AutoF1(short numero, string escuderia) : base(numero, escuderia) { }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : base(numero, escuderia) 
        {
            CaballosDeFuerza = caballosDeFuerza;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Caballos de Fuerza: {CaballosDeFuerza}");
            return stringBuilder.ToString();
        }


        public static bool operator ==(AutoF1 a1, AutoF1 b1)
        {
            return (a1.Numero == b1.Numero && a1.Escuderia == b1.Escuderia && a1.CaballosDeFuerza == b1.CaballosDeFuerza);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 b1)
        {
            return !(a1 == b1);
        }
    }
}