using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    public class ValidarRespuesta
    {
        public static bool validaS_N(char c)
        {
            if(c == 's' || c == 'S')
            {
                return true;
            }

            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            int n = 0;
            bool flag = true;

            do
            {
                Console.WriteLine("Ingrese un número:");
                if (flag)
                {
                    n = int.Parse(Console.ReadLine());
                    flag = false;
                }
                else
                {
                    n = n + int.Parse(Console.ReadLine());
                }

                Console.WriteLine("¿Continuar? S/N");
            } while (ValidarRespuesta.validaS_N(char.Parse(Console.ReadLine())));

            Console.WriteLine("Números sumados: {0}", n);

            Console.ReadKey();


        }
    }
}
