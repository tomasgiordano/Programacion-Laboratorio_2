using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComprobanteLogic;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Campos
        private static Stack<Comprobante> comprobantes;
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Tendrá un indexeador de solo lectura que recibira com oparametor un producto y un booleano
        /// Devolvera una lista comprobante con los comprobantes:
        /// correspondientes a ese producto (comparar los codigos de los productos, el que recibe como parametro
        /// y el dela venta del comprobante.
        /// Si el booleano es true la lista deberá estar ordenada por fecha de emision (misma fecha de la venta)
        /// de la más antigua a la mas reciente, sino deberá mostrarse tal como l odevuelve la pila.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="ordenar"></param>
        /// <returns></returns>
        public List<Comprobante> this[Producto producto, bool ordenar]
        {
            get
            {
                return new List<Comprobante>();
            }
        }
        
        
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
        /// Tengo que instanciar el campo comprobantes
        /// </summary>
        static Comiqueria()
        {
            Comiqueria.comprobantes = new Stack<Comprobante>();
        }
        
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
        /// Recibe un objeto de tipo Comprobante, y lo agrega a la coleccion de comprobantes, verificando
        /// previamente que no haya comprobante igual en la pila.
        /// </summary>
        /// <returns>True si pudo agregarlo, false de lo contrario</returns>
        public bool AgregarComprobante(Comprobante comprobante)
        {
            if (!Comiqueria.comprobantes.Contains(comprobante))
            {
                Comiqueria.comprobantes.Push(comprobante);
                return true;
            }

            return false;
        }
        //Pésimo todo esto
        /// <summary>
        /// Recime solo una venta. Con este dato, 
        /// instancia una nueva factura tipo B y la agrega a la lista de comprobantes
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        private bool AgregarComprobante(Venta venta)
        {
            Comprobante f = new Factura(venta, Factura.TipoFactura.B);

            this.AgregarComprobante(f);
            

            return true;
        }

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
        /// Devuelve true si el comprobante ya se encuentra en la pila de comprobantes
        /// </summary>
        /// <param name="comiqueria"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Comiqueria comiqueria, Comprobante comprobante)
        {
            return Comiqueria.comprobantes.Contains(comprobante);
        }

        public static bool operator !=(Comiqueria comiqueria, Comprobante comprobante)
        {
            return !(comiqueria == comprobante);
        }

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
