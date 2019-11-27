using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            char opcion;

            Cajon c = new Cajon(50);
            c.AgregarFruta(new Fruta());

            do
            {
                Console.WriteLine("{0}", c.MostrarContenido());
                Console.WriteLine("----------------------------");
                Console.WriteLine("1- Agregar fruta");
                Console.WriteLine("2- Quitar fruta al azar");
                Console.WriteLine("3- Salir");

                opcion = char.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case '1':
                        if(c.AgregarFruta(new Fruta()))
                        {
                            Console.Clear();
                            Console.WriteLine(">> Se agregó con éxito una nueva fruta\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">> No se pudo agregar la fruta\n");
                        }
                        break;

                    case '2':
                        if (c.QuitarFruta())
                        {
                            Console.Clear();
                            Console.WriteLine(">> Se quitó con éxito una fruta\n");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(">> No se pudo quitar ninguna fruta\n");
                        }
                        break;
                    case '3':
                        seguir = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine(">> Opción incorrecta\n");
                        break;
                }

            } while (seguir);

        }
    }
}
