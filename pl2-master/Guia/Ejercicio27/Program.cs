using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio27
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();

            #region LISTA
            Console.WriteLine("### LISTA");
            //Creo la lista
            List<int> numsList = new List<int>();

            //Le cargo enteros random de 1 a 20
            for (int i = 0; i < 20; i++)
            {
                numsList.Add(rnd.Next(1, 20));
                Thread.Sleep(10);
            } 

            //Mostrar como fueron agregados
            Console.WriteLine("Sin ordenadar:");
            imprimirListaEnConsola(numsList);

            //Mostrar de forma creciente
            Console.WriteLine("\nOrdenados:");
            numsList.Sort();
            imprimirListaEnConsola(numsList);

            //Mostrar de forma decreciente
            Console.WriteLine("\nOrdenados decreciente:");
            numsList.Sort(ordenarDecreciente);
            imprimirListaEnConsola(numsList);

            #endregion

            #region PILAS
            Console.WriteLine("\n\n### STACK");
            Console.WriteLine("Stack no se puede ordenar, lo que hago es copiarlo en una lista y trabajar ahí\n");

            //Creo una pila/stack
            Stack<int> numsStack = new Stack<int>();

            //Cargo valores random
            for(int i = 0; i<20; i++)
            {
                numsStack.Push(rnd.Next(1, 20));
                Thread.Sleep(10);
            }

            //Mostrar como fueron agregados
            Console.WriteLine("Sin ordenadar:");
            foreach (int item in numsStack)
            {
                Console.Write("{0} ", item);
            }

            //Mostrar de forma creciente
            Console.WriteLine("\nOrdenados");
            //Creo una lista auxiliar
            List<int> auxL = new List<int>();
            //Llamo a la funcion que pasa los items del stack a una lista y lo guardo en la lista auxiliar
            auxL = DeStackaLista(numsStack);
            //Ordeno la lista auxiliar
            auxL.Sort();
            //La imprimo en consola
            imprimirListaEnConsola(auxL);

            //Mostrar de forma decreciente
            Console.WriteLine("\nOrdenados decreciente");
            //Ya tengo la lista en auxiliar asi que la ordeno usando la funcion de decreciente
            auxL.Sort(ordenarDecreciente);
            //Imprimo la lista decreciente
            imprimirListaEnConsola(auxL);

            #endregion

            #region COLA
            Console.WriteLine("\n\n### COLA");
            Console.WriteLine("Cola no se puede ordenar, lo que hago es copiarlo en una lista y trabajar ahí\n");

            Queue<int> numsQueue = new Queue<int>();

            for(int i = 0; i<20; i++)
            {
                numsQueue.Enqueue(rnd.Next(1, 20));
            }

            Console.WriteLine("Sin ordenadar:");

            foreach (int item in numsQueue)
            {
                Console.Write("{0} ", item);
            }

            //Piso la lista anterior
            auxL = DeColaAlista(numsQueue);

            Console.WriteLine("\nOrdenados");
            //Ordeno la lista auxiliar
            auxL.Sort();
            //La imprimo en consola
            imprimirListaEnConsola(auxL);

            //Mostrar de forma decreciente
            Console.WriteLine("\nOrdenados decreciente");
            //Ya tengo la lista en auxiliar asi que la ordeno usando la funcion de decreciente
            auxL.Sort(ordenarDecreciente);
            //Imprimo la lista decreciente
            imprimirListaEnConsola(auxL);



            #endregion




            Console.ReadKey();

        }
        public static List<int> DeColaAlista(Queue<int> n)
        {
            List<int> lista = new List<int>();

            foreach(int item in n)
            {
                lista.Add(item);
            }

            return lista;
        }

        public static List<int> DeStackaLista(Stack<int> n)
        {
            List<int> lista = new List<int>();

            foreach(int item in n)
            {
                lista.Add(item);
            }

            return lista;
        }

        public static int ordenarDecreciente(int n1, int n2)
        {
            return -n1.CompareTo(n2);
        }

        public static void imprimirListaEnConsola(List<int> n)
        {
            for (int i = 0; i < n.Count; i++)
            {
                Console.Write("{0} ", n[i]);
            }
        }
    }
}
