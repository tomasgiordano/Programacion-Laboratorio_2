using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio41
{
    public abstract class Llamada
    {
        #region Fields

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propieties
        public abstract float CostoLlamada { get; }

        /// <summary>
        /// Devuelve la duración de la llamada
        /// </summary>
        public float Duracion
        {
            get { return this.duracion; }
        }
        /// <summary>
        /// Devuelve el número de destino de la llamada
        /// </summary>
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        /// <summary>
        /// Devuelve el número de origen de la llamada
        /// </summary>
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion

        #region Builder
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Muestra los datos de la llamada. Mostrar deberá ser declarado como virtual, protegido y retornará un string que contendrá
        /// los atributos propios de la clase Llamada
        /// </summary>
        /// <returns>Un string con los datos de la llamada.</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuración: {0}", this.Duracion);
            sb.AppendFormat("\nNúmero destino: {0}", this.NroDestino);
            sb.AppendFormat("\nNúmero origen: {0}", this.NroOrigen);
            return sb.ToString();
        }
        /// <summary>
        /// Recibirá dos Llamadas. Se utilizará para ordenar una lista de llamadas de forma ascendente.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
            {
                return 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        ///(utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
        ///origen son iguales en ambas llamadas.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(!l1.Equals(l2))
            {
                return false;
            }
            else if (l1.NroOrigen != l2.NroOrigen)
            {
                return false;
            }
            else
            {
                return (l1.NroDestino != l2.NroDestino);
            }
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }


        #endregion

    }
}
