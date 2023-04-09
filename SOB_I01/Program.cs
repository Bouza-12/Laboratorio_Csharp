using Sumador;

namespace SOB_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I01 - Sumador");

            Sumador.Sumador s1 = new Sumador.Sumador();

            Sumador.Sumador s2 = new Sumador.Sumador(5);

            Console.WriteLine("Cantidad de sumas en s2: {0}", ((int)s1));
            Console.WriteLine("Cantidad de sumas en s2: {0}", ((int)s2));

            Console.WriteLine("Suma 1: {0}", s1.Sumar(450, 150));
            Console.WriteLine("Suma 2: {0}", s1.Sumar(s1.Sumar(25,175), 150));
            Console.WriteLine("Suma 4: {0}", s1.Sumar(s1.Sumar("150 + 300 ", "+ 550 "), "= 1000"));
            Console.WriteLine("La cantidad de sumas de s1 y s2 son iguales: {0}", s1 | s2);
            Console.WriteLine("Suam 3: {0}", s1.Sumar("2 + 2 = ", "4"));
            Console.WriteLine("La sumas de s1 y s2 es: {0}", s1 + s2);
            Console.WriteLine("Suma 5: {0}", s1.Sumar(1920, 1080));
            Console.WriteLine("La cantidad de sumas de s1 y s2 son iguales: {0}", s1 | s2);


        }
    }
}