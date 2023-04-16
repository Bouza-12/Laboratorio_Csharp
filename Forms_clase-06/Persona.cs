using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms_clase_06
{
    public class Persona
    {
        private string _nombre;
        private int _legajo;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public Persona(string nombre, int legajo)
        {
            Nombre = nombre;
            Legajo = legajo;
        }

        public override string  ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Legajo: {Legajo}");
            return sb.ToString();
        }



    }
}
