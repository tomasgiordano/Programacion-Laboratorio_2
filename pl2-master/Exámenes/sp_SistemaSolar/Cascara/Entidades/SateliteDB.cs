using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class SateliteDB
    {
        public static bool Guardar(Satelite satelite)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Entidades.Properties.Settings.Default.Conexion);
                SqlCommand comando = new SqlCommand();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO [planetario].dbo.satelites(nombre,duraOrbita,duracionRotacion) VALUES('" + satelite.Nombre + "', '" + satelite.DuraOrbita + "', '" + satelite.DuraRotacion + "')";
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<Satelite> Leer()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Entidades.Properties.Settings.Default.Conexion);
                SqlCommand comando = new SqlCommand();
                List<Satelite> satelites = new List<Satelite>();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * from planetario";

                SqlDataReader reader = comando.ExecuteReader();

                while (!(reader.Read()))
                {
                    satelites.Add(new Satelite(Convert.ToInt32(reader["duraOrbita"]), Convert.ToInt32(reader["duracionRotacion"]), reader["nombre"].ToString()));
                }
                conexion.Close();
                return satelites;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
