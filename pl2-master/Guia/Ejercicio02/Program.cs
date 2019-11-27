using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";
            int num;
            long elevado;

            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());
            while (num <= 0)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("[ERROR]");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" - El número no puede ser 0 (cero), re-ingrese:\n");
                num = int.Parse(Console.ReadLine());
            }
            elevado = (long)Math.Pow(num, 2);
            Console.WriteLine("El {1} al cuadrado es: {0}", elevado, num);
            elevado = (long)Math.Pow(num, 3);
            Console.WriteLine("El {1} al cubo es: {0}", elevado, num);

            Console.ReadKey();
        }
    }
}
