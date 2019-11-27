using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";

            /*
             * CON VECTORES PARALELOS, todo villero y sin comprobar ingresos.
             */

            int[] aCobrar = new int[10];
            int[] valorHora = new int[10];
            int[] cantAnios = new int[10];
            int[] cantHoras = new int[10];
            int[] estado = new int[10];

            int porcentaje;
            int opcion;
            int i = 0;

            do
            {
                Console.WriteLine("[!] - Ingresar el valor de la hora");
                valorHora[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("[!] - Ingresar los años de antigüedad");
                cantAnios[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("[!] - Ingresar la cantidad de horas trabajadas en el mes");
                cantHoras[i] = int.Parse(Console.ReadLine());

                estado[i] = 1;

                Console.WriteLine("[?] - Continuar cargando empleados? 1: Sí 2: No.");
                opcion = int.Parse(Console.ReadLine());

                i++;

            } while (opcion == 1 && i<10);

            for (i = 0; i < 10; i++)
            {
                if(estado[i] == 1)
                {
                    aCobrar[i] = valorHora[i] * cantHoras[i];
                    aCobrar[i] = aCobrar[i] + (cantAnios[i] * 150);
                    porcentaje = (aCobrar[i] * 13) / 100;
                    aCobrar[i] = aCobrar[i] - porcentaje;

                    Console.WriteLine("[i] - El empleado debe cobrar: ${0}", aCobrar[i]);
                }

            }

            Console.ReadKey();
        }
    }



}

