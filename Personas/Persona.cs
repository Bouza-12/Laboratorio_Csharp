namespace Personas
{
    public class Persona
    {
        private string _nombre;
        private long _dni;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public long DNI { get { return _dni; } private set { _dni = value; } }

        public Persona(long dni, string nombre) 
        {
            _nombre = nombre;
            _dni = dni;
        }

        public Persona(string nombre)
        {
            _nombre = nombre;
        }


        public override string ToString()
        {
            return $"Nombre: {Nombre}, DNI: {DNI}";
        }
    }
}