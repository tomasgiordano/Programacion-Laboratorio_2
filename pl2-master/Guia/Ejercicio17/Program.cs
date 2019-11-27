using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            
            Boligrafo bBlue = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo bRed = new Boligrafo(50, ConsoleColor.Red);

            Boligrafo bGreen = new Boligrafo(30, ConsoleColor.Green);

            string paint;

            bBlue.Pintar(10, out paint);
            bRed.Pintar(20, out paint);
            bRed.Pintar(20, out paint);
            bRed.Pintar(20, out paint);
            bGreen.Pintar(11, out paint);
            bGreen.Pintar(33, out paint);
            bGreen.Recargar();
            bGreen.Pintar(100, out paint);

            Console.ReadLine();
        }
    }
}
