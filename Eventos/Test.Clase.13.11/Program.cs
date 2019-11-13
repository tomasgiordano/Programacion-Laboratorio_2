using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase._13._11;
namespace Test.Clase._13._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("Juan","Perez",123);
            e1.limiteSueldo += new LimiteSueldoDelegado(new Program().ManejadorDeEvento);
            e1.limiteMejorado += new LimiteSueldoMejoradoDel(ManejadorDeEventoMejorado);

            e1.Sueldo = 33000;
            Console.WriteLine(e1.ToString());
            Console.ReadKey();

        }

        private void ManejadorDeEvento(double sueldo,Empleado e1)
        {
            Console.WriteLine("Se quiso asignar en sueldo el valor: {0}", sueldo);
            Console.WriteLine(e1.ToString());
        }

        private static void ManejadorDeEventoMejorado(Empleado e,EmpleadoEventArgs sender)
        {
            Console.WriteLine(sender.SueldoAsignar);
            Console.WriteLine(e.ToString());
        }

        private void ManejadorDeEventoMejorado2(Empleado e,EmpleadoEventArgs sender)
        {
            Program.ManejadorDeEventoMejorado(e, sender);
        }
    }

}
