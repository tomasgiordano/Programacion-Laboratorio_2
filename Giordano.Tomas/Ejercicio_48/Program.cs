using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48.Entidades;

namespace Ejercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura,Recibo> C = new Contabilidad<Factura, Recibo>();

            Recibo r1 = new Recibo();
            Factura f1 = new Factura(2222);
            Recibo r2 = new Recibo(1111);
            Factura f2 = new Factura(3333);
            Recibo r3 = new Recibo(4444);
            Factura f3 = new Factura(5555);

            C += f1;
            C += r1;
            C += f2;
            C += r2;
            C += f3;
            C += r3;

            
        }
    }
}
