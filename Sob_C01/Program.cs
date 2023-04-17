namespace Sob_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio C01 - Conversor binario recargado");

            Console.WriteLine($"Numero decimal: 8     | binario: {Conversor.ConvertirDecimalABinario(8)}");
            Console.WriteLine($"Numero binario: 100  | decimal: {Conversor.ConvertirBinarioADecimal(100)}");


        }

        class NumeroBinario
        {
            private string numero;
            
            public NumeroBinario(string numero)
            {
                this.numero = numero;
            }

            //public static string operator +(NumeroBinario NumeroDecimal(string binario), NumeroDecimal num = new NumeroDecimal(numDecimal))
            //{

            //} 
        }

        class NumeroDecimal
        {
            private double numeroDecimal;

            public NumeroDecimal(double numeroDecimal)
            {
                this.numeroDecimal = numeroDecimal;
            }

            public static implicit operator int(NumeroDecimal numero)
            {
                return (int)numero;
            }

            public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
            {
                NumeroBinario binario = new NumeroBinario(Conversor.ConvertirDecimalABinario(numeroDecimal));
                return   binario;
            }
            
        }


    }
}