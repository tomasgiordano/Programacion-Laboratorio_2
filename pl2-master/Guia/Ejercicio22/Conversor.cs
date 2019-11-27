using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class Conversor
    {

        /// <summary>
        /// Recibe un decimal y lo convierte en binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna un string del binario</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int n = (int)numero;

            if (n > 0)
            {
                while (true)
                {
                    if ((n % 2) != 0)
                    {
                        binario = "1" + binario;
                    }
                    else
                    {
                        binario = "0" + binario;
                    }
                    n /= 2;

                    if (n <= 0)
                    {
                        break;
                    }
                }
            }
            else
            {
                return "Valor inválido";
            }
            return binario;
        }

        /// <summary>
        /// Recibe un binario en formato string
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Devuelve un double con el binario convertido en decimal</returns>
        public static double BinarioDecimal(string binario)
        {
            int n = 0;
            bool flag = true;

            for (int x = binario.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (binario[x] == '0' || binario[x] == '1')
                {
                    n += (int)(int.Parse(binario[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    flag = false;
                }
            }

            if (flag)
            {
                return n;
            }
            else
            {
                return -1;
            }
        }

    }
}
