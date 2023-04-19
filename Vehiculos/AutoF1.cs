using System.Security.AccessControl;
using System.Text;

namespace Vehiculos
{
    public class AutoF1
    {
        private short _cantidadCombustible;
        private bool _enCompetencia;
        private string _escuderia;
        private short _numero;
        private short _vueltasRestantes;

        #region Getters y Setters
        public short CantidadCombustible
        {
            get { return _cantidadCombustible; }
            set { _cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return _enCompetencia; }
            set { _enCompetencia= value; }
        }
        public string Escuderia
        {
            get { return _escuderia; }
            set { _escuderia = value; }
        }
        public short Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
            }
        }
        public short VueltasRestantes
        {
            get { return _vueltasRestantes; }
            set
            {
                _vueltasRestantes = value;
            }
        }
        #endregion

        public AutoF1(short numero, string escuderia)
        {
            _numero = numero;
            _escuderia = escuderia;
            _enCompetencia = false;
            _cantidadCombustible = 0;
            _vueltasRestantes = 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Escuderría : {Escuderia}");
            sb.AppendLine($"Numero: {Numero}");
            sb.AppendLine($"En Competencia: {EnCompetencia}");
            sb.AppendLine($"Combustible Restante: {CantidadCombustible}");
            sb.AppendLine($"Vueltas Restantes: {VueltasRestantes}");
            sb.AppendLine("============================================");
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 b1)
        {
            return (a1.Numero == b1.Numero && a1.Escuderia == b1.Escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 b1)
        {
            return !(a1 == b1);
        }
    }
}