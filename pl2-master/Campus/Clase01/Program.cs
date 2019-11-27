using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Ni ganas de usar cinco variables, y agarro el maximo para hacer lo de los primos
            int i = 1;
            bool flag = true;
            int num = 0;
            int max = 0;
            int min = 0;
            int acu = 0;

            do
            {
                Console.WriteLine("{0}) - Ingrese un número: ", i);
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (flag == true)
                    {
                        max = num;
                        min = num;
                        flag = false;
                    }
                    if (max < num)
                    {
                        max = num;
                    }
                    if (min > num)
                    {
                        min = num;
                    }
                    acu += num;
                    i++;
                }
                else
                {
                    Console.WriteLine("Número incorrecto, re intente.");
                }

            } while (i <= 5);

            Console.WriteLine("• El número más chico ingresado fue: {0} Y el más grande: {1} Con un promedio de: {2}", min, max, acu / i);


            //Numeros primos:
            Console.WriteLine("• Numeros primos del maximo ({0}):", max);

            int contador;
            bool primo;

            for (i = 2; i <= max; i++)
            {
                contador = 2;
                primo = true;

                while (primo && contador < i)
                {
                    if (i % contador == 0)
                    {
                        primo = false;
                    }
                    else
                    {
                        contador += 1;
                    }
                }

                if (primo)
                {
                    Console.Write("{0} ", i);
                }

            }

            Console.ReadKey();
        }
    }
}
