using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";

            bool flag = false;
            int numA;
            int numB;
            int i;

            //Pedir año de inicio
            do
            {
                Console.WriteLine("[!] - Ingresar año de inicio");
                if (flag)
                {
                    Console.WriteLine("[X] - Error, solo números");
                }
                flag = true;

            } while (!int.TryParse(Console.ReadLine(), out numA));

            //Pedir año de fin
            flag = false;
            do
            {
                Console.WriteLine("[!] - Ingresar año de fin");
                if (flag)
                {
                    Console.WriteLine("[X] - Error, solo números");
                }
                flag = true;

            } while (!int.TryParse(Console.ReadLine(), out numB));

            //Encontrar bisiestos
            for (i = numA; i <= numB; i++)
            {
                if (i % 400 == 0)
                {
                    Console.WriteLine("[!] - El año {0} es bisiesto.", i);
                }
                else if (i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine("[!] - El año {0} es bisiesto.", i);
                }
                else
                {
                    Console.WriteLine("[X] - El año {0} no es bisiesto.", i);
                }
            }




            Console.ReadKey();


        }
    }
}
