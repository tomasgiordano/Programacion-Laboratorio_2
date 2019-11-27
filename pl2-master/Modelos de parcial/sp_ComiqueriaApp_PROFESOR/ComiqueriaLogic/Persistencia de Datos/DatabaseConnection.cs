using ComiqueriaLogic;
using System;
using System.Data.SqlClient;

namespace ComiqueriaDataAccess
{
    public abstract class DatabaseConnection
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        protected static AccionesDB ultimaAccion;

        static DatabaseConnection()
        {
            DatabaseConnection.conexion = new SqlConnection(@"Server=Onyxia\SQLEXPRESS;Database=Comiqueria;Trusted_Connection=True;");
            DatabaseConnection.comando = new SqlCommand();
            DatabaseConnection.comando.Connection = DatabaseConnection.conexion;
        }

        protected static SqlConnection Conexion
        {
            get
            {
                return DatabaseConnection.conexion;
            }
        }

        protected static SqlCommand Comando
        {
            get
            {
                return DatabaseConnection.comando;
            }
        }

        protected static void Ejecutar()
        {
            try
            {                
                DatabaseConnection.Conexion.Open();
                DatabaseConnection.Comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new ComiqueriaException("Ocurrió un error en la base de datos.", ex);
            }
            finally
            {
                if (DatabaseConnection.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DatabaseConnection.Conexion.Close();
                }
            }
        }
    }
}
