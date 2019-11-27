using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Variables

        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        #endregion

        #region Propiedades

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value >= 1)
                {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Validará que el stock ingresado sea mayor o igual a
        /// cero, sino no lo actualizará.
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
                
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor protegido. Inicializará el campo “codigo” con el método estático NewGuid de la
        /// clase Guid.Iniciar el resto de los campos con los parámetros de entrada.
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
            this.codigo = Guid.NewGuid();
        }

        #endregion

        #region Métodos
        
        /// <summary>
        /// Convierte un producto a su código GUID
        /// </summary>
        /// <param name="p">Producto a saber su GUID</param>
        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        /// <summary>
        /// devolver un string con los datos de un producto:
        /// descripción, código, precio y stock.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("- Descripción: {0}\n", this.Descripcion);
            sb.AppendFormat("- Código: {0}\n", this.codigo);
            sb.AppendFormat("- Precio: ${0}\n", this.Precio);
            sb.AppendFormat("- Stock: {0} unidades", this.Stock);
            return sb.ToString();
        }




        #endregion

    }
}
