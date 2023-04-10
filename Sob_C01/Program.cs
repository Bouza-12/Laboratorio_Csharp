namespace Sob_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio C01 - Conversor binario recargado");

            Console.WriteLine($"Numero decimal: 9     | binario: {Conversor.ConvertirDecimalABinario(9)}");
            Console.WriteLine($"Numero binario: 1001  | decimal: {Conversor.ConvertirBinarioADecimal(1001)}");


        }

        class NumeroBinario
        {
            private string numero;
            
            private NumeroBinario(string numero)
            {
                this.numero = numero;
            }

            public static string operator +(NumeroBinario NumeroDecimal(string binario), NumeroDecimal num = new NumeroDecimal(numDecimal))
            {

            } 
        }

        class NumeroDecimal
        {
            private double numeroDecimal;

            private NumeroDecimal(double numeroDecimal)
            {
                this.numeroDecimal = numeroDecimal;
            }

            public static implicit operator int(NumeroDecimal numero)
            {
                return (int)numero;
            }

            public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
            {
                return  NumeroBinario Conversor.ConvertirDecimalABinario(numeroDecimal);
            }
            
        }
    }
}