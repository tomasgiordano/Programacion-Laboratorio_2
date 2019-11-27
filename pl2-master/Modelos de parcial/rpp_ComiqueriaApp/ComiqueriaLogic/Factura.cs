using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobanteLogic
{
    public class Factura:Comprobante
    {

        #region Atributos

        public enum TipoFactura
        {
            A, B, C, E
        }

        private TipoFactura tipoFactura;

        private DateTime fechaVencimiento;

        #endregion


        #region Constructores

        //Mal hecha las sobrecargas y la lógica dentro

        /// <summary>
        /// Inicializa el campo FechaVencimiento con la fecha actual más la cantidad de días que recibe en el parámetro de tipo
        /// int diásParaVencimiento.
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="diasParaVencimineto"></param>
        /// <param name="tipoFactura"></param>
        public Factura(Venta venta, int diasParaVencimineto, TipoFactura tipoFactura):this(venta,tipoFactura)
        {
            
            this.fechaVencimiento = venta.Fecha.AddDays(diasParaVencimineto);
        }

        /// <summary>
        /// Cargara díasParaVecnimiento con el vlaor por defecto de 15 días.
        /// </summary>
        /// <param name="venta"></param>
        /// <param name="tipoFactura"></param>
        public Factura(Venta venta, TipoFactura tipoFactura):base(venta)
        {
            this.tipoFactura = tipoFactura;
            this.fechaVencimiento = this.fechaVencimiento.AddDays(15);
        }


        #endregion

        /// <summary>
        /// Devolvera true si el objeto a comprar es de tipo factura,
        /// la fecha de emision es la misma y el tiipo de factura es el mismo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {

            return (obj.GetType() == typeof(Factura));

        }

        //un comprobante tiene una venta, esa venta tiene un producto

        /// <summary>
        /// Devuelve un string con los datos de la factura.
        /// </summary>
        /// <returns></returns>
        public override string GenerarComprobante()
        {
            //Esto así no
            Venta v = this.Venta;
            Producto p = (Producto)v;
            
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("- FACTURA: {0}\n", this.tipoFactura);
            sb.AppendFormat("- Fecha emisión: {0}\n", this.fechaEmision);
            sb.AppendFormat("- Fecha vencimiento: {0}\n", this.fechaVencimiento);

            sb.AppendFormat("- Producto {0}\n", p.Descripcion);
            sb.AppendFormat("- Cantidad {0}\n", v.Cantidad);
            sb.AppendFormat("- Precio ${0}\n", p.Precio);

            sb.AppendFormat("- Subtotal ${0}1\n", (p.Precio * v.Cantidad));
            sb.AppendFormat("- Importe IVA ${0}1\n", ((21 * (p.Precio * v.Cantidad)) / 100) );
            sb.AppendFormat("- Importe total {0}1\n", Venta.CalcularPrecioFinal(p.Precio,v.Cantidad));

            //sb.AppendFormat("{0}", base.Venta.ObtenerDescripcionBreve());

            return sb.ToString();
        }



    }
}
