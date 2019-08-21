using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cubo;
            int cuadrado;

            Console.Write("Ingrese un numero positivo: ");
            num=int.Parse(Console.ReadLine());

            if(num>=0)
            {
                cubo = (int) Math.Pow(num,3);
                cuadrado = (int)Math.Pow(num,2);
                Console.WriteLine("El cuadrado de {0} es {1}.\nEl cubo de {0} es {2}.",num,cuadrado,cubo);
            }
            else
            {
                Console.WriteLine("El numero ingresado es negativo.");
            }
            Console.ReadKey();
        }
    }
}
