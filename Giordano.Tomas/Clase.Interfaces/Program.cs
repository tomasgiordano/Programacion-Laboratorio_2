using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase.Interfaces.Entidades;

namespace Clase.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Privado APrivado = new Privado(1000,100,5);
            Comercial AComercial = new Comercial(2000,150,200);
            Carreta Carretilla = new Carreta(50);
            Deportivo ADeportivo = new Deportivo(1500,"ASD123",100);
            Familia AFamilia = new Familia(900,"QWE456",6);

            Console.WriteLine(Gestion.MostrarImpuestoNacional(APrivado));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(AComercial));
            Console.WriteLine(Gestion.MostrarImpuestoNacional(ADeportivo));
                

        }
    }
}
