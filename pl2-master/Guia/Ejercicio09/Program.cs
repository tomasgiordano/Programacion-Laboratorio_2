using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    class Program
    {

        public static void imprimirAsteriscos(int cant)
        {
            for (int i = 0; i <cant; i++)
            {
                Console.Write("*");
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";

            int altura;
            int i;
            int j = 1;

            Console.WriteLine("[!] - Ingrese altura de la piramide:");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i=0; i<altura; i++)
            {
                imprimirAsteriscos(j);
                Console.WriteLine();
                j=j+2;
            }

            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "TEXT"));

            Console.ReadKey();

        }


    }

}
