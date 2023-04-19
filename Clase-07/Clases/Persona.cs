using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_07.Clases
{
    abstract internal class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _dni;

        protected string _nome; //se comporta como privado para quien usa la clase, pero publica para las cla
                                //clases heredadas

        #region Properties
        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public string Apellido { get { return _apellido; } set { _apellido = value; } }

        public int DNI 
        { 
            get { return _dni; } 
            private set 
            {
                _dni = Validador.ValidarDniOrThrow(value);
            } 
        }

        public string NombreCompleto
        {
            get { return $"{Apellido}, {Nombre}"; }
        }

        #endregion

        public Persona(string nombre, string apellido, int dni):this(dni)
        {
            Nombre=nombre;
            Apellido=apellido;
            //DNI = dni;
        }

        public Persona(int dni)
        {
            DNI = dni;
        }

        public override string ToString()
        {
            return $"Apellido y Nombre: {NombreCompleto}, DNI: {DNI}";
        }

        public virtual string Saludar() //el virtual se usa para poder hacer override en hijos
        {
            return "Hola soy " + NombreCompleto;
        }

        public abstract string MetodoAbstacto(); //debe ser implementado en los clases derivadas

    }
}
