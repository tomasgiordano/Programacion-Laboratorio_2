using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int i;
            int num;
            int max = 0;
            int min = 0;
            float acu = 0;
            float prom;
            bool flag = false;

            for (i = 1; i < 6; i++)
            {
                Console.WriteLine("|{0}| Ingrese un numero: ", i);

                while (int.TryParse(Console.ReadLine(), out num) == false)
                {
                    Console.WriteLine("Error vuelva a intentar:");
                }

                num = int.Parse(Console.ReadLine());
                acu = acu + num;

                if (flag == false)
                {
                    max = num;
                    min = num;
                    flag = true;
                }

                if (num > max)
                {
                    max = num;
                }
                else if (num < min)
                {
                    min = num;
                }

            }//End For

            prom = acu / 5;

            Console.WriteLine("El num max fue: {0}", max);
            Console.WriteLine("El num min fue: {0}", min);
            Console.WriteLine("El promedio fue: {0:G}", prom);

            Console.ReadKey();
        }
    }
}
