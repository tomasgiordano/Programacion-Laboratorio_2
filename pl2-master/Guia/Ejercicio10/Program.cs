using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {

        public static string imprimirAsteriscos(int cant)
        {
            string aux = "";

            for (int i = 0; i < cant; i++)
            {
                aux = aux + "*";
            }

            return aux;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            int altura;
            int i;
            int j = 1;

            Console.WriteLine("[!] - Ingrese altura de la piramide:");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (i = 0; i < altura; i++)
            {
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + imprimirAsteriscos(j).Length/2 ) + "}", imprimirAsteriscos(j) ));
                j = j + 2;
            }

            Console.ReadKey();

        }


    }

}
