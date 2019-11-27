using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ComiqueriaDataAccess
{
    public class ProductosDB : DatabaseConnection
    {
        public delegate void ProductoDBDelegate(AccionesDB accion);
        public static event ProductoDBDelegate ProductosDBChanged;

        public static void Insert(string descripcion, double precio, int stock)
        {         
            ProductosDB.Comando.CommandText = "INSERT INTO dbo.Productos (descripcion, precio, stock) VALUES (@descripcion, @precio, @stock);";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Insert);
        }   

        public static void Update(int codigo, double nuevoPrecio)
        {
            ProductosDB.Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecio);
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Insert);
        }

        public static void Delete(int codigo)
        {
            ProductosDB.Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Ejecutar();
            ProductosDBChanged.Invoke(AccionesDB.Insert);
        }

        public static List<Producto> SelectAll()
        {
            List<Producto> productosList = new List<Producto>();

            try
            {
                ProductosDB.Comando.CommandText = "SELECT * FROM dbo.Productos";

                ProductosDB.Conexion.Open();
                SqlDataReader sqlReader = ProductosDB.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int codigo = Convert.ToInt32(sqlReader["codigo"]);
                    string descripcion = sqlReader["descripcion"].ToString();
                    double precio = Convert.ToDouble(sqlReader["precio"]);
                    int stock = Convert.ToInt32(sqlReader["stock"]);
                    Producto producto = new Producto(codigo, descripcion, stock, precio);
                    productosList.Add(producto);
                }
            }
            catch (Exception ex)
            {
                throw new ComiqueriaException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (ProductosDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ProductosDB.Conexion.Close();
                }
            }          

            return productosList;
        }
    }
}
