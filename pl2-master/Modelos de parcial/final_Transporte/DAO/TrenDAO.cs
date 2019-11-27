using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesSPyFinal;
using System.Data;

namespace Datos
{
    public static class TrenDAO
    {
        #region Atributos
        public static SqlConnection conexion;
        public static SqlCommand comando;
        #endregion

        #region Constructor

        static TrenDAO()
        {
            string conexionURL = @"Data Source=.\SQLEXPRESS; Initial Catalog=Ejercicio61; Integrated Security = True";

            try
            {
                conexion = new SqlConnection(conexionURL);
                comando = new SqlCommand();
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region Guardar
        /// <summary>
        /// Guardar tren en la BD
        /// </summary>
        /// <param name="tren"></param>
        /// <returns></returns>
        public static bool Guardar(Transporte tren)
        {
            bool retorno = false;

            try
            {
                Random rVagones = new Random();

                string consulta = String.Format(
                    "INSERT INTO trenes (cantidad_vagones, fabricante, velocidad) VALUES ('{0}','{1}','{2}')"
                    , rVagones.Next(0,10).ToString(), tren.Fabricante,tren.Velocidad);

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
        #endregion

        #region Leer lista

        public static List<Tren> Leer()
        {
            List<Tren> trenesL = new List<Tren>();
            Tren tren;

            string consulta = String.Format("Select * from trenes");

            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int velocidad = int.Parse(oDr["velocidad"].ToString());
                    EFabricante fabricante = (EFabricante)oDr["fabricante"];
                    string cantVagones = oDr["cantidad_vagones"].ToString();
                    


                    tren = new Tren(velocidad, fabricante, cantVagones);

                    trenesL.Add(tren);

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

            return trenesL;

        }

        #endregion

    }
}
