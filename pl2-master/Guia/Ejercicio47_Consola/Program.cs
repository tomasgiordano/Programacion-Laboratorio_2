using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio47;

namespace Ejercicio47_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("SuperGarchaLiga Argentina");
            Torneo<EquipoBasket> torneoBasket = new Torneo<EquipoBasket>("SuperBasket 2019");

            EquipoFutbol riverga = new EquipoFutbol("River", new DateTime(1901,05,25));
            EquipoFutbol bokita = new EquipoFutbol("Boca", new DateTime(1905, 04, 03));
            EquipoFutbol bojito = new EquipoFutbol("Independiente", new DateTime(1905, 01, 01));
            EquipoFutbol virgenciaLP = new EquipoFutbol("Gimnasia ELP", new DateTime(1887, 06, 03));
            EquipoFutbol rasin = new EquipoFutbol("Racing", new DateTime(1887, 06, 03));
            EquipoFutbol snlrnzo = new EquipoFutbol("San Lorenzo", new DateTime(1887, 06, 03));
            EquipoFutbol veleshh = new EquipoFutbol("Velez", new DateTime(1887, 06, 03));


            torneoFutbol += riverga;
            torneoFutbol += bokita;
            torneoFutbol += bojito;
            torneoFutbol += virgenciaLP;
            torneoFutbol += veleshh;
            torneoFutbol += snlrnzo;
            torneoFutbol += rasin;

            Console.WriteLine(torneoFutbol.Mostrar());

            Console.WriteLine();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine(torneoFutbol.JugarPartido);
            }
            

            Console.ReadKey();


        }
    }
}
