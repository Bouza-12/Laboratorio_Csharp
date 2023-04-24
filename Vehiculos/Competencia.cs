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
        private List<VehiculoDeCarrera> competidores;
        public enum ETipoCompetencia { AutoF1, MotoCross};
        private ETipoCompetencia _tipo;

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
        public List<VehiculoDeCarrera> Competidores
        {
            get { return competidores; }
            set { competidores = value; }
        }

        public ETipoCompetencia Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        #endregion
        private Competencia() { }

        public Competencia(short cantVueltas, short cantCompetidores, ETipoCompetencia tipo)
        {
            CantidadCompetidores = cantCompetidores;
            CantidadVueltas = cantVueltas;
            Tipo = tipo;
        }

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

        public static bool operator ==(Competencia c, VehiculoDeCarrera auto)
        {
            if((c.Tipo == Competencia.ETipoCompetencia.AutoF1 && auto.GetType() == typeof(AutoF1)) ||
                (c.Tipo == Competencia.ETipoCompetencia.MotoCross && auto.GetType() == typeof(MotoCross)))
            {
                return c.Competidores.Contains(auto);
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera auto)
        {
            return !(c == auto);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera auto)
        {
            if (!c.Competidores.Contains(auto))
            {
                c.Competidores.Add(auto);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera auto)
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
