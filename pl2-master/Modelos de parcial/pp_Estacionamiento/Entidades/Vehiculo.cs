using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        #region Constructor

        /// <summary>
        /// La fecha de ingreso será cargada 3 horas previas a la creación del objeto mediante el método DateTime.Now.AddHours(-3). 
        /// </summary>
        /// <param name="patente"></param>
        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente; //Llamo a la propiedad para cargar la patente
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// La propiedad Patente validará que la misma tenga 6 caracteres, caso contrario no la asignará. 
        /// </summary>
        public string Patente
        {
            get { return this.patente; }

            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }
                else
                {
                    this.patente = null;
                }
                
            }
        }

        #endregion

        /// <summary>
        /// ConsultarDatos no tendrá implementación en Vehiculo
        /// </summary>
        /// <returns></returns>
        public abstract string ConsultarDatos();


        /// <summary>
        ///  podrá ser anulado en las clases derivadas. Utilizará StringBuilder para retornar los datos del Vehiculo (reutilizar ToString) y la fecha y hora de ingreso
        /// </summary>
        /// <returns></returns>
        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("- Fecha de ingreso: {0}", this.ingreso);
            sb.AppendFormat("\n- {0}", this.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Utilizará el método Format de la clase String y retornará la Patente del Vehiculo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Patente: {0}", this.Patente);
        }

        /// <summary>
        /// Dos Vehiculos serán iguales si tienen la misma patente y son objetos de la misma clase
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if((v1.Patente == v2.Patente) && v1.Equals(v2) )
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        

    }
}
