using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class MiClase
    {
        //atributos
        public static string nombre;
        public static int edad;

        //metodos
        public static void MostrarEdad()
        {
            Console.WriteLine("Edad: {0}",MiClase.edad);
        }

        public static string RetornarNombre()
        {
            return MiClase.nombre;
        }

        public static bool CompararNombres(string nombre)
        {
            Boolean retorno=false;

            if(MiClase.nombre==nombre)
            {
                retorno = true;    
            }

            return retorno;
        }

    }
}
