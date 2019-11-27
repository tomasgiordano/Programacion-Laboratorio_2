using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Campos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Tendrá un indexador que recibirá como parámetro un código Guid y devolverá el producto
        /// de la lista de productos que corresponda con ese código.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Producto this[Guid codigo]
        {
            get
            {
                for(int i = 0; i < productos.Count; i++)
                {
                    if((Guid)productos[i] == codigo)
                    {
                        return productos[i];
                    }
                }

                return null;
            }
        }
        #endregion

        #region Constructor
        
        /// <summary>
        /// Instancio ambas listas
        /// </summary>
        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// ListarProductos devuelve un Dictionary<Guid, string>. Cada elemento del diccionario
        ///corresponderá con cada producto en la lista de productos.La key será el código del
        ///producto y el valor la descripción del producto.
        /// </summary>
        /// <returns></returns>
        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> dic = new Dictionary<Guid, string>();

            for (int i = 0; i < productos.Count; i++)
            {
                dic.Add((Guid)productos[i], productos[i].Descripcion);
            }

            return dic;
        }

        /// <summary>
        /// ListarVentas devuelve un string conteniendo la descripción breve de cada venta en la lista
        ///de ventas.Una descripción por línea.Utilizar las herramientas que expone la clase Venta.
        ///La lista deberá estar ordenada por fecha de la más reciente a la más antigua (Para
        ///esto utilice el mecanismo que conozca y prefiera. Si lo necesita, agregue un método extra o
        ///lo que requiera).
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            StringBuilder sb = new StringBuilder();

            this.ventas.Sort(Comiqueria.OrdenarVentaPorFecha);
            
            for (int i = 0; i < this.ventas.Count; i++)
            {
                sb.AppendFormat("{0}", this.ventas[i].ObtenerDescripcionBreve());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Ordena las ventas comparando sus fechas de forma ascendente
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static int OrdenarVentaPorFecha(Venta v1, Venta v2)
        {
            return v2.Fecha.CompareTo(v1.Fecha);
        }

        /// <summary>
        /// El método Vender agrega una nueva venta a la lista de ventas.
        /// </summary>
        /// <param name="producto">Producto a agregar</param>
        /// <param name="cantidad">Cantidades del producto</param>
        public void Vender(Producto producto, int cantidad)
        {
            //Venta test = new Venta(producto, cantidad);
            this.ventas.Add(new Venta(producto, cantidad));
        }

        public void Vender(Producto producto)
        {
            this.Vender(producto, 1);
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// La sobrecarga del operador == debe verificar si el producto se encuentra en la lista de
        ///productos comparando la descripción.Si dos productos tienen la misma descripción son el
        ///mismo producto.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            for(int i = 0; i < comiqueria.productos.Count; i++)
            {
                if (comiqueria.productos[i].Descripcion == producto.Descripcion)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        /// <summary>
        /// La sobrecarga del operador + debe agregar un producto a la lista de producto siempre que
        /// el mismo ya no exista en la lista.
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            if(comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
            }

            return comiqueria;
        }

        #endregion

    }
}
