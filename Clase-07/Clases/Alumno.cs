using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    internal class Alumno : Persona
    {
        private int _legajo;

        public int Legajo
        {
            get { return _legajo; }
            private set { _legajo = Validador.ValidarLegajoOrThrow(value); }
        }

        public Alumno(string nombre, string apellido, int dni, int legajo) : base(nombre, apellido, dni)
        {
            Legajo = legajo;
        }

        public Alumno(int dni, int legajo) : base(dni)
        {
            Legajo = legajo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Legajo: {Legajo}";
        }

        //public string Saludar()
        //{
        //    return $"Hola soy {NombreCompleto} y mi legajo es {Legajo}" ;
        //}
        
        public override string Saludar()
        {
            return $"{base.ToString} y mi legajo es {Legajo}";
        }

        public override string MetodoAbstacto()
        {
            return "Un método astracto implementado";
        }
    }
}
