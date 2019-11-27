using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    public class Persona
    {
        #region Atributos
        //Privados, pero los hago publicos para probar
        public int id;
        public string nombre;
        public string apellido;
        #endregion

        //Crear un constructor que reciba los 3 parámetros y otro que sólo reciba nombre y apellido.
        #region Constructores

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int id):this(nombre,apellido)
        {
            this.id = id;
        }

        #endregion

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nNombre: {0}", this.nombre);
            sb.AppendFormat("\nApellido: {0}", this.apellido);
            sb.AppendFormat("\nID: {0}", this.id);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.id + " " + this.nombre + " " + this.apellido;
        }


    }
}
