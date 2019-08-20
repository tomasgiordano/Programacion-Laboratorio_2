using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int acum=0;
            int numMax=0;
            int numMin=0;
            float promedio;
            Boolean flag=true;
            int i;

            Console.WriteLine("Ingrese 5 numeros: ");
            for(i=0;i<5;i++)
            {
                Console.Write("Numero {0}: ",i+1);
                num=int.Parse(Console.ReadLine());
                acum = acum + num;
                if(flag)
                {
                    numMax = num;
                    numMin = num;
                    flag = false;
                }
                else
                { 
                    if(num>numMax)
                    {
                        numMax = num;
                    }
                    if(num<numMin)
                    {
                        numMin = num;
                    }
                }
            }

            promedio =(float) acum / 5;

            Console.WriteLine("El mayor numero ingresado fue: {0}\nEl menor numero ingresado fue: {1}\nEl promedio de los numeros da: {2}",numMax,numMin,promedio);
            Console.ReadLine();
        }
    }
}
