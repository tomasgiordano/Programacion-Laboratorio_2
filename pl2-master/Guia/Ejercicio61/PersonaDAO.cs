using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/*
    AGREGAR LOS SIGUIENTES 5 MÉTODOS:
    i. Guardar: guardará una nueva persona en la base de datos.
    ii. Leer: retornará la lista de personas de la base de datos.
    iii. LeerPorID: traerá una persona, filtrando por ID.
    iv. Modificar: modificará una persona a partir de su ID.
    v. Borrar: eliminará una persona de la base de datos a partir de su ID.
*/
namespace Ejercicio61
{
    public static class PersonaDAO
    {
        #region Atributos
        public static SqlConnection conexion;
        public static SqlCommand comando;
        #endregion

        #region Constructor

        static PersonaDAO()
        {
            string conexionURL = @"Data Source=.\SQLEXPRESS; Initial Catalog=Ejercicio61; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(conexionURL);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        #endregion

        public static bool GuardarPersona(Persona p)
        {
            bool retorno = false;

            try
            {
                string consulta = String.Format(
                    "INSERT INTO Persona (nombre, apellido) VALUES ('{0}','{1}')", p.nombre, p.apellido);

                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return retorno;
        }

        public static List<Persona> LeerPersonas()
        {
            List<Persona> personas = new List<Persona>();
            Persona persona;

            string consulta = String.Format("Select * from Persona");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int id = int.Parse(oDr["ID"].ToString());
                    string nombre = oDr["Nombre"].ToString();
                    string apellido = oDr["Apellido"].ToString();

                    persona = new Persona(nombre, apellido, id);

                    personas.Add(persona);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return personas;

        }

        public static Persona LeerPorID(int id)
        {
            Persona p = null;
            //string consulta = String.Format("Select * from Persona WHERE ID = {0}", id);
            string consulta = String.Format("Select * from Persona");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    if(int.Parse(oDr["ID"].ToString()) == id)
                    {
                        int idaux = int.Parse(oDr["ID"].ToString());
                        string nombre = oDr["Nombre"].ToString();
                        string apellido = oDr["Apellido"].ToString();

                        p.apellido = apellido;
                        p.nombre = nombre;
                        p.id = idaux;

                        break;
                    }

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }


            return p;

        }

    }
}
