using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio19";

            Sumador s1 = new Sumador();
            Console.WriteLine(s1.CantidadSumas);
            Console.WriteLine(s1.Sumar(500, 500));
            Console.WriteLine(s1.CantidadSumas);
            Console.WriteLine(s1.Sumar("lala", "lele"));
            Console.WriteLine(s1.CantidadSumas);
            Console.WriteLine(s1.Sumar("lili", "lulu"));
            Console.WriteLine(s1.Sumar("sada", "sede"));
            Console.WriteLine(s1.CantidadSumas);

            Console.WriteLine("------------------");

            Sumador s2 = new Sumador(3);
            Console.WriteLine(s2.CantidadSumas);
            Console.WriteLine(s2.Sumar(500, 500));
            Console.WriteLine(s2.CantidadSumas);
            Console.WriteLine(s2.Sumar("lala", "lele"));
            Console.WriteLine(s2.CantidadSumas);
            Console.WriteLine(s2.Sumar("lili", "lulu"));
            Console.WriteLine(s2.Sumar("sada", "sede"));
            Console.WriteLine(s2.CantidadSumas);

            Console.WriteLine("------------------");

            Console.WriteLine(s1.CantidadSumas);
            Console.WriteLine(s2.CantidadSumas);
            Console.WriteLine(s1 + s2);

            if (s1 | s2)
            {
                Console.WriteLine("Misma cantidad de sumas");
            }
            else
            {
                Console.WriteLine("Diferente cantidad de sumas");
            }

            Console.WriteLine((int)(s1));
            Console.WriteLine((int)(s2));

            s1.CantidadSumas = 1;
            s1.CantidadSumas = 1;
            s1.CantidadSumas = 1;

            if (s1 | s2)
            {
                Console.WriteLine("Misma cantidad de sumas");
            }
            else
            {
                Console.WriteLine("Diferente cantidad de sumas");
            }

            Console.WriteLine( (int)(s1) );
            Console.WriteLine( (int)(s2) );


            Console.ReadKey();


        }
    }
}
