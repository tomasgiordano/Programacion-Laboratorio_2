using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioO3
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            int i = 0;
            int num;
            int contador;
            bool esPrimo;

            Console.WriteLine("[!] Ingrese un número mayor a cero:");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                while (num <= 0)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[ERROR]");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" - El número {0} es incorrecto, debe ser mayor a cero.\n[!] Re-ingrese:\n", num);
                    num = int.Parse(Console.ReadLine());
                }

                for (i = 2; i <= num; i++)
                {
                    contador = 2;
                    esPrimo = true;
                    while (esPrimo && contador < i)
                    {
                        if (i % contador == 0)
                        {
                            esPrimo = false;
                        }
                        else
                        {
                            contador += 1;
                        }
                    }
                    if (esPrimo)
                    {
                        Console.WriteLine("Es primo: {0}", i);
                    }
                }

            }
            else
            {
                Console.WriteLine("[X] - Error, solo números");
                Console.ReadKey();
            }


            Console.ReadKey();

        }
    }
}
