using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno a1 = new Alumno("Daiana", "Allegue", 1064650);
            Alumno a2 = new Alumno("Patricia", "De Muria", 100657);
            Alumno a3 = new Alumno("Morita", "De Muria", 200564);

            a1.Estudiar(8, 7);
            a2.Estudiar(6, 5);
            a3.Estudiar(2,3);

            a1.CalcularFinal();
            a2.CalcularFinal();
            a3.CalcularFinal();

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine(a3.Mostrar());

            Console.ReadKey();

        }
    }
}
