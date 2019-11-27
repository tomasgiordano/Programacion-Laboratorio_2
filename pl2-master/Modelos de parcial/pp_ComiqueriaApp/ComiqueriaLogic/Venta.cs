using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Campos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Propiedades

        /// <summary>
        /// Tiene una propiedad que devuelve la fecha de la venta. Es de sólo lectura y tiene el mismo
        /// modificador de acceso que el constructor de instancia.
        /// </summary>
        internal DateTime Fecha
        {
            get { return this.fecha; }
        }
        #endregion

        #region Constructores

        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        /// <summary>
        /// El constructor de instancia inicializará el campo producto y llamará al método Vender
        /// pasándole la cantidad indicada como argumento.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }


        #endregion

        #region Métodos
        /// <summary>
        /// Le restará al stock del producto la cantidad que le pasaron por parámetro.
        ///ii.Inicializará el campo fecha con la fecha actual completa.
       ///iii.Inicializará el campo precioFinal con el valor retornado por el método
      ///CalcularPrecioFinal, al cual se le pasará el precio unitario del producto y la cantidad.
        /// </summary>
        /// <param name="cantidad"></param>
        private void Vender(int cantidad)
        {
            this.producto.Stock = this.producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }


        /// <summary>
        /// El método ObtenerDescripcionBreve devuelve un string breve y en una sola línea indicando
        /// fecha, descripción del producto y precio final.De esta forma: “fecha – descripción –
        ///precioFinal”
        /// </summary>
        /// <returns></returns>
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} - ", this.Fecha);
            sb.AppendFormat("{0} - ", this.producto.Descripcion);
            sb.AppendFormat("${0}\n", Math.Round(this.precioFinal,2));
            return sb.ToString();
        }

        /// <summary>
        /// Calculará el precio final multiplicando
        /// el precio unitario por la cantidad comprada y a este resultado le aplicará el porcentaje de
        /// IVA que esté indicado en el campo porcentajeIva.
        /// </summary>
        /// <param name="precioUnidad"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioFinal = precioUnidad * cantidad;

            //Sacar el porcentajeIva:
            double porcentaje = (porcentajeIva * precioFinal) / 100;

            //Aplico el porcentaje al precio final
            return precioFinal + porcentaje;
        }

        #endregion

    }
}
