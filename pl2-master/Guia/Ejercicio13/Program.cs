using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {

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


    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            double n;

            Console.WriteLine("Ingresar un número decimal para convertir en binario");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("En binario: {0}", Conversor.DecimalBinario(n));

            Console.WriteLine("El binario en decimal: {0}", Conversor.BinarioDecimal(Conversor.DecimalBinario(n)));

            Console.ReadKey();

        }
    }

}
