using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql() {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=patentes-sp-2018.bak; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e) {
                throw new Exception("Error al conectar con la base de datos", e);
            }

        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            foreach (Patente p in datos) {
                try
                {
                    comando.CommandText = String.Format("INSERT INTO " + tabla + "(tipo, codigo) VALUES ('{0}','{1}')", p.TipoCodigo, p.CodigoPatente);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al guardar en la base de datos", e);
                }
                finally {
                    conexion.Close();
                }
            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            Queue<Patente> patentesAux = new Queue<Patente>();

            try
            {
                comando.CommandText = String.Format("SELECT * from " + tabla);
                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Patente p = new Patente();
                    p.TipoCodigo = (Entidades.Patente.Tipo)oDr["tipo"];
                    p.CodigoPatente = oDr["codigo"].ToString();
                    patentesAux.Enqueue(p);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer de la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }

            datos = patentesAux;
        }
    }
}
