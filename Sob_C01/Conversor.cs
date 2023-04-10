using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sob_C01
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numero)
        {
            StringBuilder sb = new StringBuilder();

            while(numero > 1) 
            {
                sb.Append($"{numero % 2}");
                numero = numero / 2;
            }
            sb.Append($"{numero}");
            return sb.ToString();
        }

        public static int ConvertirBinarioADecimal(int binario)
        {
            int digito;
            int posicion = 0;
            int resultado = 0;
            int[] potenciasDe2 = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };

            while( binario > 0)
            {
                digito = binario % 10;
                if(digito == 1)
                {
                    resultado += potenciasDe2[posicion];
                }
                posicion++;
                binario = binario / 10;
            }

            return resultado;

        }
    }
}
