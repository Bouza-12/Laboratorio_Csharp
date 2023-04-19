using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<AutoF1> competidores;

        #region Getters y Setters
        public short CantidadCompetidores
        {
            get { return _cantidadCompetidores; }
            private set { _cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get => _cantidadVueltas;
            set
            {
                _cantidadVueltas = value;
            }
        }
        public List<AutoF1> Competidores
        {
            get { return competidores; }
            set { competidores = value; }
        }
        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Vueltas: {CantidadVueltas}");
            sb.AppendLine($"Cantidad de Competidores: {CantidadCompetidores}");
            sb.AppendLine($"Competidores");
            foreach (AutoF1 competidores in competidores)
            {
                sb.AppendLine(competidores.ToString());
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, AutoF1 auto)
        {
            return c.Competidores.Contains(auto);
        }

        public static bool operator !=(Competencia c, AutoF1 auto)
        {
            return !(c == auto);
        }

        public static bool operator +(Competencia c, AutoF1 auto)
        {
            if (!c.Competidores.Contains(auto))
            {
                c.Competidores.Add(auto);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, AutoF1 auto)
        {
            if (c.Competidores.Contains(auto))
            {
                c.Competidores.Remove(auto);
                return true;
            }
            return false;
        }

    }
}
