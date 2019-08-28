using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.Entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa();

            //cosa1.EstablecerValor(1);
            //cosa1.EstablecerValor("SoyLaCosa1");
            //cosa1.EstablecerValor(DateTime.Now);

            Console.WriteLine("{0}", cosa1.Mostrar());

            Console.ReadLine();
        }
    }
}
