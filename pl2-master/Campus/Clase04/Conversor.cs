using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    public class Conversor
    {
        public static string EnteroBinario(int numero)
        {
            string binario = "";
            while (numero > 0)
            {
                binario = (numero % 2).ToString() + binario;
                numero = numero / 2;
            }
            return binario;
        }

        public static int BinarioDecimal(string binario)
        {
            int entero = 0;

            for (int i = 1; i <= binario.Length; i++)
            {
                entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
            }

            return entero;
        }

    }
}

