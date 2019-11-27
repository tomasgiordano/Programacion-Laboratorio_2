using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase02;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculador calculador = new Calculador();
            bool salir = false;
            int opcion = 0;

            do
            {
                Console.WriteLine("1 - Convertir de Binario a Decimal");
                Console.WriteLine("2 - Convertir de Decimal a Binario");
                Console.WriteLine("3 - Mostrar acumulador en Binario");
                Console.WriteLine("4 - Mostrar acumulador en Decimal");
                Console.WriteLine("0 - Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un numero binario a convertir:");
                            string aux = Console.ReadLine();
                            Console.WriteLine(Conversor.BinarioDecimal(aux));

                            calculador.acumular(aux);

                            break;
                        case 2:
                            Console.WriteLine("Ingrese un numero entero para convertir a binario:");
                            if (int.TryParse(Console.ReadLine(), out int auxInt))
                            {
                                Console.WriteLine(Conversor.EnteroBinario(auxInt));
                            }
                            else
                            {
                                Console.WriteLine("Error, solo numeros.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Valor del acumulador en Binario:");
                            Console.WriteLine(calculador.getResultadoBinario());
                            break;
                        case 4:
                            Console.WriteLine("Valor del acumulador en Entero");
                            Console.WriteLine(calculador.getResultadoEntero());
                            break;
                        case 0:
                            salir = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, debe ingresar un número.");
                }



            } while (salir == false);

        }
    }
}
