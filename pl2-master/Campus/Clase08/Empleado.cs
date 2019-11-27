using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08
{
    public class Empleado
    {
        #region Atributos

        private string nombre;
        private string apellido;
        private string legajo;
        private EPuestoJerarquico puesto;
        private int salario;

        #endregion

        #region Constructor

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
        {
            this.nombre     = nombre;
            this.apellido   = apellido;
            this.legajo     = legajo;
            this.puesto     = puesto;
            this.salario    = salario;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Dos empleados son iguales si comparten el mismo legajo.
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.legajo == e2.legajo;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Muestra los datos del empleado
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}", this.nombre);
            sb.AppendFormat("\nApellido: {0}", this.apellido);
            sb.AppendFormat("\nLegajo: {0}", this.legajo);
            sb.AppendFormat("\nPuesto: {0}", this.puesto);
            sb.AppendFormat("\nSalario: {0}", this.salario);
            return sb.ToString();
        }

        #endregion

    }
}
