using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            string dia;
            string mes;
            string anio;
            string aux;
            DateTime fechaNacimiento;

            Console.WriteLine("[!] - Ingresar día de nacimiento");
            dia = Console.ReadLine();
            Console.WriteLine("[!] - Ingresar número de mes de nacimiento");
            mes = Console.ReadLine();
            Console.WriteLine("[!] - Ingresar año de nacimiento");
            anio = Console.ReadLine();

            aux = dia + "/" + mes + "/" + anio;

            fechaNacimiento = DateTime.Parse(aux);

            Console.WriteLine("Resultado: {0}", DateTime.Now - fechaNacimiento);

            Console.ReadKey();

        }
    }
}
