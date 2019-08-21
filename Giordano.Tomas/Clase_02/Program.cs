using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_02.Entidades;
namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
           /* MiClase.edad = 18;
            MiClase.nombre = "Tomas";

            MiClase.MostrarEdad();
            Console.WriteLine("Nombre: {0}",MiClase.RetornarNombre());
            Console.WriteLine("Nombres iguales? {0}",MiClase.CompararNombres("Tomas"));
            Console.WriteLine();
            Console.ReadKey();
            */

            //Otro ej con librerias
            Sello.mensaje = "HOLA MUNDO!";
            Console.WriteLine("{0}", Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine("{0}", Sello.Imprimir());
            Console.ReadLine();
            Sello.color = ConsoleColor.Yellow;
            Sello.mensaje = "OTRO MENSAJE!";
            Sello.ImprimirEnColor();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("{0}", Sello.Imprimir());
            Console.ReadKey();
        }
    }
}
