using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class DirectorTecnico : Persona
    {
        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            private set { _fechaNacimiento = value; }
        }

        public DirectorTecnico(string nombre) : base(nombre) { }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : base(nombre)
        {
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            return $"DT: {Nombre}, Fecha de Nacimento [{FechaNacimiento}";
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if(dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento) { return true; }
            else { return false; }
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2 ) { return !(dt1 == dt2); }


    }
}
