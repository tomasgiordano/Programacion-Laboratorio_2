using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoArea
    {
        public static double CalcularCuadrado(double a)
        {
            return a*a;
        }

        public static double calcularTriangulo(double a, double b)
        {

            return (a*b)/2;
        }

        /// <summary>
        /// Recibe radio
        /// </summary>
        /// <param name="a">Radio</param>
        /// <returns>Area del circulo</returns>
        public static double calcularCirculo(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            
            Console.WriteLine("CALCULAR AREA CUADRADO.\n Ingrese un lado del cuadrado:");
            Console.WriteLine("El area del cuadrado es: {0}",CalculoArea.CalcularCuadrado(int.Parse(Console.ReadLine())));

            Console.WriteLine("\n\nCALCULAR AREA TRIANGULO.\n Ingrese la base:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("El area del triangulo es: {0}", CalculoArea.calcularTriangulo(b,h));

            Console.WriteLine("\n\nCALCULAR AREA CIRCULO.\n Ingrese el radio:");
            Console.WriteLine("El area del circulo es: {0:N2}", CalculoArea.calcularCirculo(int.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
    }
}
