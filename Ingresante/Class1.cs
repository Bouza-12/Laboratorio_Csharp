using System.Text;

namespace Ingresante
{
    public class Ingresante
    {
        private List<string> _cursos = new List<string>();
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public int Edad { get { return _edad; } set { _edad = value; } }
        public string Genero { get { return _genero; } set { _genero = value; } }
        public string Nombre { get { return _nombre; }
            set
            {
                _nombre = value;
            }
        }
        public string Pais { get { return _pais; }
            set
            {
                _pais = value;
            }
        }

        public List<string> Cursos { get { return _cursos; } set { _cursos = value; } }


        public Ingresante(string nombre, string direccion, string genero, string pais, List<string> cursos, int edad)
        {
            Nombre = nombre;
            Direccion = direccion;
            Genero = genero;
            Pais = pais;
            Cursos = cursos;
            Edad = edad;
        }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Dirección: {Direccion}");
            sb.AppendLine($"Edad: {Edad}");
            sb.AppendLine($"Género: {Genero}");
            sb.AppendLine($"País: {Pais}");
            sb.AppendLine($"Cursos:");
            foreach( var item in Cursos )
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        } 

    }
}