using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    public class Local : Llamada
    {
        #region Fields
        protected float costo;
        #endregion

        #region Properties
        public override float CostoLlamada { get { return this.CalcularCosto(); } }
        #endregion

        #region Builder
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion

        #region Methods
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", base.Mostrar());
            sb.AppendFormat("\nCosto de llamada: {0}", this.CostoLlamada);
            return sb.ToString();
        }

        /// <summary>
        /// Equals retornará true sólo si el objeto que recibe es de tipo Local.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Local));
        }

        /// <summary>
        /// ToString reutilizará el código del método Mostrar.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion

    }
}
