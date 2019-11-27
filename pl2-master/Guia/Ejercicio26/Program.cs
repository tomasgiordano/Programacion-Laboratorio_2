using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            Random rnd = new Random();

            for(int i = 0; i < 20; i++)
            {
                nums.Add(rnd.Next(1, 20));
                Thread.Sleep(10);
            }

            //Mostrar como fueron agregados
            Console.WriteLine("Sin ordenadar:");
            imprimirListaEnConsola(nums);

            //Mostrar de forma creciente
            Console.WriteLine("\n\nOrdenados:");
            nums.Sort();
            imprimirListaEnConsola(nums);

            //Mostrar de forma decreciente
            Console.WriteLine("\n\nOrdenados decreciente:");
            nums.Sort(ordenarDecreciente);
            imprimirListaEnConsola(nums);


            Console.ReadKey();

        }

        public static int ordenarDecreciente(int n1, int n2)
        {
            return -n1.CompareTo(n2);
        }

        public static void imprimirListaEnConsola(List<int> n)
        {
            for(int i = 0; i < n.Count; i++)
            {
                Console.Write("{0} ",n[i]);
            }
        }

    }
}
