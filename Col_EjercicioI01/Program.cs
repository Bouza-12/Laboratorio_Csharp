namespace Col_EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I01 - Números locos");

            List<int> list = new List<int>();
            
            Random rdm = new Random();

            for (int i = 0; i < 20; i++)
            {
                list.Add(rdm.Next(-100, 100));
            }

            Console.WriteLine("Numero sin ordenar: ");
            foreach (int numero in list)
            {
                Console.WriteLine(numero);
            }

            //list.Sort();

            list.Sort((numero1, numero2) =>
            {
                return numero2.CompareTo(numero1);
            });

            Console.WriteLine("Numero ordenados: ");

            foreach (int numero in list)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Numeros Positivos");

            foreach(int numero in list)
            {
                if (numero > 0) Console.WriteLine(numero);
            }

            Console.WriteLine("Numeros Negativos");

            foreach (int numero in list)
            {
                if (numero < 0) Console.WriteLine(numero);
            }
        }



    }
}