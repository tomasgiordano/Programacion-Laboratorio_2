using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ComiqueriaLogic.Comun;

namespace ComiqueriaLogic.Entidades
{
    public static class ComiqueriaDAO
    {
        #region Atributos
        private static SqlCommand comando;
        private static SqlConnection conexion;

        #endregion

        

        #region Constructor

        static ComiqueriaDAO()
        {
            try
            {
                conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Comiqueria; Integrated Security = True");
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                ComiqueriaException ex = new ComiqueriaException("No se agregar el producto");
                ArchivoTexto.Escribir(ex.Ruta, ex.Texto, true);
                throw ex;
            }

        }

        #endregion

        #region Métodos


        public static List<Producto> LeerProductos()
        {
            List<Producto> productoAux = new List<Producto>();
            Producto producto;

            string consulta = String.Format("Select * from Comiqueria");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int codigo = int.Parse(oDr["Codigo"].ToString());
                    string descripcion = oDr["Descripcion"].ToString();
                    int stock = int.Parse(oDr["Stock"].ToString());
                    double precio = double.Parse(oDr["Precio"].ToString());

                    producto = new Producto(codigo, descripcion, stock, precio);

                    productoAux.Add(producto);
                }
            }
            catch (Exception e)
            {
                ComiqueriaException ex = new ComiqueriaException("Hubo un error al leer los productos");
                ArchivoTexto.Escribir(ex.Ruta, ex.Texto, true);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return productoAux;
        }


        /// <summary>
        /// Es horrible, sin terminar
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Quitar(Producto p)
        {
            List<Producto> productosAux = new List<Producto>();

            bool retorno = false;
            

            try
            {
                string consulta = String.Format("Select * from Comiqueria");
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int codigo = int.Parse(oDr["Codigo"].ToString());
                    string descripcion = oDr["Descripcion"].ToString();
                    int stock = int.Parse(oDr["Stock"].ToString());
                    double precio = double.Parse(oDr["Precio"].ToString());

                    //int codigo, string descripcion, int stock, double precio)
                    p = new Producto(codigo, descripcion, stock, precio);

                    productosAux.Add(p);
                }

                for (int i = 0; i < productosAux.Count; i++)
                {
                    if(productosAux[i].ToString() == p.ToString())
                    {
                        //asddddddddddd
                        break;
                    }
                }

            }
            catch (Exception e)
            {
                ComiqueriaException ex = new ComiqueriaException("Hubo un error al quitar los productos");
                ArchivoTexto.Escribir(ex.Ruta, ex.Texto, true);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }


        /// <summary>
        /// Inserta en la DB un producto, recibiendo por parametro su información
        /// El código/id que es autoincremental, lo hace desde el script BD
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <returns></returns>
        public static bool Insertar(string descripcion, double precio, int stock)
        {
            bool retorno = false;

            try
            {
                string consulta = string.Format(
                    "INSERT INTO Comiqueria (Descripcion, Precio, Stock, Codigo) VALUES ('{0}','{1}','{2}')",
                    descripcion, precio, stock);

                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception e)
            {
                ComiqueriaException ex = new ComiqueriaException("No se pudo insertar el producto");
                ArchivoTexto.Escribir(ex.Ruta, ex.Texto, true);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

        #endregion


        #region Eventos



        #endregion

    }
}
