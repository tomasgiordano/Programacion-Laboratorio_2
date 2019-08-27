using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Tomas", "Giordano", 43444906);
            //persona1.nombre = "Tomas";
            //persona1.apellido = "Giordano";
            //persona1.dni = 43444906;

            Persona persona2 = new Persona("Mauro","Luna",33222666);
            //persona2.nombre = "Mauro";
            //persona2.apellido = "Luna";
            //persona2.dni = 33222666;

            Console.WriteLine("{0}",persona1.Mostrar());
            Console.WriteLine("{0}", persona2.Mostrar());
            Console.ReadLine();
            
        }
    }
}
