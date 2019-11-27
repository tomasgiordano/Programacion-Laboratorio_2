using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static double calcular(int a, int b, char o)
        {
            switch (o)
            {
                case '+':
                    return a + b;
                    break;
                case '-':
                    return a - b;
                    break;
                case '*':
                    return a * b;
                    break;
                case '/':
                    if (validar(b))
                    {
                        return a / b;
                    }
                    else
                    {
                        return 0;
                    }
                    break;
            }
            return 0;
        }

        public static bool validar(int b)
        {
            return b!=0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            string seguir = "";
            int a;
            int b;
            char o;
            double r;

            do
            {

                Console.WriteLine("Ingrese el primer número");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el operando: +, -, * ó /");
                o = char.Parse(Console.ReadLine());
                if(o != '+' || o != '-' || o != '*' || o != '/')
                {
                    r = Calculadora.calcular(a,b,o);
                    Console.WriteLine("El resultado es: {0}", r);
                }
                else
                {
                    Console.WriteLine("Operando incorrecto");
                }

                Console.WriteLine("Continuar operando con otros números? s/n");
                seguir = Console.ReadLine();

            } while ( seguir == "s" || seguir == "S" );

        }
    }
}
