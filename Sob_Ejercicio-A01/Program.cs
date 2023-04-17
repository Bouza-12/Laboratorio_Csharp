using Temperaturas;

namespace Sob_Ejercicio_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio A01 - Fahrenheit 451");

            bool parseadoOK = false;
            double temp;
            string numeroStr;
            char tipoTemp;

            do
            {
                Console.WriteLine("Ingrese un tipo de temperatura (F, C o K) o 's' para salir: ");
                tipoTemp = Console.ReadLine()[0];
                tipoTemp = char.ToLower(tipoTemp);

                switch (tipoTemp )
                {
                    case 'c':
                        Console.WriteLine("Ingrese la temperatura en gredo Celsius:");
                        numeroStr = Console.ReadLine();
                        parseadoOK = double.TryParse(numeroStr, out temp);
                        if (parseadoOK)
                        {
                            Celsius celsius = new Celsius(temp);
                            Console.WriteLine($"Farenheit: {(Farenheit)celsius}");
                            Console.WriteLine($"Celsius: {celsius}");
                            Console.WriteLine($"Kelvin: {(Kelvin)celsius}");
                        }
                        break;
                    case 'f':
                        Console.WriteLine("Ingrese la temperatura en gredo Farenheit:");
                        numeroStr = Console.ReadLine();
                        parseadoOK = double.TryParse(numeroStr, out temp);
                        if(parseadoOK )
                        {
                            Farenheit farenheit = new Farenheit(temp);
                            Console.WriteLine($"Farenheit: {temp}");
                            Console.WriteLine($"Celsius: {(Celsius)farenheit}");
                            Console.WriteLine($"Kelvin: {(Kelvin)farenheit}");
                        }
                        break;
                    case 'k':
                        Console.WriteLine("Ingrese la temperatura en gredo Kelvin:");
                        numeroStr = Console.ReadLine();
                        parseadoOK = double.TryParse(numeroStr, out temp);
                        if (parseadoOK)
                        {
                            Kelvin kelvin = new Kelvin(temp);
                            Console.WriteLine($"Farenheit: {(Farenheit)kelvin}");
                            Console.WriteLine($"Celsius: {(Celsius)kelvin}");
                            Console.WriteLine($"Kelvin: {kelvin}");
                        }
                        break;
                    case 's':
                        break;
                    default: Console.WriteLine("No ingresó una opción correcta.");
                        break;
                }


            } while (!tipoTemp.Equals('s'));

        }
    }
}