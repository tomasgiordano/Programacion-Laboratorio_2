using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            if (valor > min && valor < max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";

            int valorMin = 0;
            int valorMax = 0;
            float acuNum = 0;
            int num = 0;
            bool flag = true;

            //Son 10, no 5
            for(int i = 1; i<=5; i++)
            {
                Console.WriteLine("[{0}] - Ingrese un nuevo número:", i);
                num = int.Parse(Console.ReadLine());

                if (Validacion.Validar( num , -100, 100) )
                {
                    if (flag)
                    {
                        valorMax = num;
                        valorMin = num;
                        flag = false;
                    }

                    if (num > valorMax)
                    {
                        valorMax = num;
                    }else if (num < valorMin)
                    {
                        valorMin = num;
                    }

                    acuNum = acuNum + num;

                }
                else
                {
                    Console.WriteLine("[X]- Valor fuera de rango");
                }
            }

            Console.WriteLine("Valor máximo: {0}\n Valor minimo: {1}\n Promedio: {2}", valorMax, valorMin, acuNum/5);

            Console.ReadKey();


        }
    }
}
