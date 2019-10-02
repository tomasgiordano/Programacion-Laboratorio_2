using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaPolimorfismo.Entidades;

namespace CentralitaPolimorfismo
{
     class Program
    {
        static void Main(string[] args)
        {
            Centralita telefonica;

            Local llamada1 = new Local("42625214", 30, "78453214",Convert.ToSingle(2.65));
            Provincial llamada2 = new Provincial("47875415", Franja.Franja_1, 21, "99886622");
            Local llamada3 = new Local("46877123", 45, "13687541", Convert.ToSingle(1.99));
            Provincial llamada4 = new Provincial(Franja.Franja_3, llamada2);

            telefonica = new Centralita("Telefonica");
            telefonica += llamada1;
            Console.WriteLine(telefonica.ToString());

            Console.ReadLine();

            telefonica += llamada2;
            Console.WriteLine(telefonica.ToString());


            Console.ReadLine();

            telefonica += llamada3;
            Console.WriteLine(telefonica.ToString());


            Console.ReadLine();

            telefonica += llamada4;
            Console.WriteLine(telefonica.ToString());


            Console.ReadLine();

            telefonica.OrdenarLLamadas();
            Console.WriteLine(telefonica.ToString());

            Console.ReadLine();

        }


    }
}
