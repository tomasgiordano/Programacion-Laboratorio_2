using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio41
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Tratando de generar un formulario
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mi central
            Centralita c = new Centralita("Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            
            //c.Llamadas.Add(l1);
            c += l1;
            Console.WriteLine(c.ToString());

            //c.Llamadas.Add(l2);
            c += l2;
            Console.WriteLine(c.ToString());

            //c.Llamadas.Add(l3);
            try
            {
                c += l3;
                Console.WriteLine(c.ToString());
            }
            catch(CentralitaException e)
            {
                Console.WriteLine(e.Message + e.NombreClase + e.NombreMetodo);
            }


            //c.Llamadas.Add(l4);
            try
            {
                c += l4;
                Console.WriteLine(c.ToString());
            }
            catch (CentralitaException e)
            {

                Console.WriteLine(e.Message + e.NombreClase + e.NombreMetodo);
            }


            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            Console.WriteLine("\nPresione una tecla para abrir el formulario principal\n");
            //Console.ReadKey();

            //Creando un formulario
            Application.Run(new FormCentral(c));

        }
    }
}
