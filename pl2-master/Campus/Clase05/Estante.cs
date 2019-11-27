using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Estante
    {
        #region Atributos
        private Producto[] _productos;
        private int _ubicacionEstante;
        #endregion Atributos

        #region Constructores
        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this._ubicacionEstante = ubicacion;
        }
        #endregion Constructores

        #region Métodos
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante e)
        {
            int i;
            string aux = "";
            for (i = 0; i < e._productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e._productos[i], null))
                {
                    aux += Producto.MostrarProducto(e._productos[i]) + "\n";
                }
                
            }
            return "Estanteria: " + e._ubicacionEstante.ToString() + "\nCon los productos:\n" + aux;
        }
        #endregion Métodos

        #region Sobrecargas

        public static bool operator ==(Estante e, Producto p)
        {
            int i;
            for (i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p) //Optimizar este código
        {
            int i;
            //Recorro todos buscando si esta repetido
            for (i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p) //Si ya existe retorna falso
                {
                    return false;
                }
            }
            //Recorro todo buscando si hay lugar libre (libre = producto null)
            for (i = 0; i < e._productos.Length; i++)
            {
                if(Object.ReferenceEquals(e._productos[i], null))
                {
                    e._productos[i] = p;
                    return true;
                }
            }
            return false;
            #region SIN OPTIMIZAR

            //int i;
            //int lugarVacio = -1;

            //for (i = 0; i < e._productos.Length; i++)
            //{
            //    if (Object.ReferenceEquals(e._productos[i], null))//Si se cumple es porque hay un lugar libre
            //    {
            //        //e._productos[i] = p;
            //        lugarVacio = i;
            //        break;
            //    }
            //}
            //for (i = 0; i < e._productos.Length; i++)
            //{
            //    if(e._productos[i] == p || lugarVacio == -1 ) //Este me tiraba error, corregio al agregar igualdades con null
            //    //if (Object.ReferenceEquals(e._productos[i], p)) //Este sí
            //    {
            //        return false; //Ya existe el producto o no hay lugar vacio
            //    }
            //}

            //e._productos[lugarVacio] = p;

            //return true;

            #endregion
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    e._productos[i] = null;
                    break;
                }
            }
            return e;
        }

        #endregion



    }
}
