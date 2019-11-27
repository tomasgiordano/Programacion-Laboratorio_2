using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class SateliteDB
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public SateliteDB()
        {
            string connectionStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=planetario; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw new Exception("Error al conectar con la base de datos", e);
            }

        }

        public bool Guardar(Satelite satelite) {

            try
            {
                comando.CommandText = String.Format("INSERT INTO Satelites (nombre, duracion_orbita,duracion_rotacion) VALUES ('{0}','{1}', '{2}')", satelite.Nombre,satelite.DuraOrbita,satelite.DuraRotacion);
                conexion.Open();
                comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar en la base de datos", e);
            }
            finally
            {
                conexion.Close();
            }


        }

        public List<Satelite> Leer() {

            List<Satelite> sateliteListAux = new List<Satelite>();

            try
            {
                comando.CommandText = String.Format("SELECT * from Satelites");
                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Satelite sat = new Satelite();

                    sat.Nombre = oDr["nombre"].ToString();
                    sat.DuraOrbita = (int)oDr["duracion_orbita"];
                    sat.DuraRotacion = (int)oDr["duracion_rotacion"];

                    sateliteListAux.Add(sat);
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


            return sateliteListAux;
        }


    }
}
