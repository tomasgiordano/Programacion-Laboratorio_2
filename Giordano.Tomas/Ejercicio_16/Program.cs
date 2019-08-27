using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Tomas","Giordano",1890);
            Alumno alumno2 = new Alumno("Marcos", "Pep", 1455);
            Alumno alumno3 = new Alumno("Carlitos", "Bank", 1997);

            alumno1.Estudiar(5,9);
            alumno2.Estudiar(4,10);
            alumno3.Estudiar(3,2);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine("{0}",alumno1.Mostrar());
            Console.WriteLine("{0}", alumno2.Mostrar());
            Console.WriteLine("{0}", alumno3.Mostrar());

            Console.ReadLine();
        }
    }
}
