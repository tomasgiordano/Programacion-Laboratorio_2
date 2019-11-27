using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            int opcion = 0;

            do
            {
                Console.WriteLine("[*] - Ingrese una opcion:\n1) Convertir binario a entero\n2) Convertir entero a binario\n3) Salir");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un numero binario a convertir:");
                            string aux = Console.ReadLine();
                            double resultado = Conversor.BinarioDecimal(aux);
                            if (resultado == -1)
                            {
                                Console.WriteLine("No se puede convertir");
                            }
                            else
                            {
                                Console.WriteLine("El resultado es: {0}", resultado);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese un numero entero para convertir a binario:");
                            if (int.TryParse(Console.ReadLine(), out int auxInt))
                            {
                                string auxS = Conversor.EnteroBinario(auxInt);
                                Console.WriteLine(auxS);
                            }
                            else
                            {
                                Console.WriteLine("Error, solo numeros.");
                            }
                            break;
                        case 3:
                            salir = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un número.");
                }



            } while (salir == false);

            //Console.ReadKey();
        }
    }
}


