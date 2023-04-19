using Clase_07.Clases;

namespace Clase_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var personaUno = new Persona("Juan", "Perez", 666);

            var alumno1 = new Alumno("Bart", "Simpson", 1478, 100045);

            //Console.WriteLine(personaUno.NombreCompleto);
            //Console.WriteLine(personaUno);

            Console.WriteLine(alumno1.Saludar());
            Console.WriteLine(alumno1);
        }
    }
}