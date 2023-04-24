using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class VehiculoDeCarrera
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
            set { _enCompetencia = value; }
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

        public VehiculoDeCarrera(short numero, string escuderia)
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
    }
}
