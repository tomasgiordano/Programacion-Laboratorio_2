using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobanteLogic
{
    //un comprobante tiene una venta, esa venta tiene un producto
    public abstract class Comprobante
    {
        #region Campos
        protected DateTime fechaEmision;
        private Venta venta;
        #endregion

        #region Propiedades
        /// <summary>
        /// Accesible desde le mismo assembly
        /// </summary>
        internal Venta Venta
        {
            get
            {
                return this.venta;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Inicializará el campo fechaEmision con la fecha de la venta. 
        /// Inicializar el resto de los campos con los parametros de entrada.
        /// </summary>
        /// <param name="venta"></param>
        public Comprobante(Venta venta)
        {
            this.venta = venta;
            this.fechaEmision = venta.Fecha;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Debe ser implementado obligatoriamente en las clases derivadas.
        /// </summary>
        /// <returns></returns>
        public abstract string GenerarComprobante();

        /// <summary>
        /// Devolverá true si el objeto a comprar es de tip oCOmprobante y la fecha de emision es la misma.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Comprobante c =  (Comprobante)obj;

            if(c.fechaEmision != this.fechaEmision)
            {
                return false;
            }

            else if (obj.GetType() != typeof(Comprobante))
            {
                return false;
            }

            return true;

        }

        #endregion

    }
}
