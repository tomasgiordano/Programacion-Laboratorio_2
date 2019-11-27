using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ComiqueriaLogic.Entidades
{

    public static class ArchivoTexto
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="datos"></param>
        /// <param name="append"></param>
        public static void Escribir(string ruta, string datos, bool append)
        {

            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, append))
                {
                    sw.WriteLine(datos);
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public static string Leer(string ruta)
        {
            string lectura;

            try
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    lectura = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return lectura;
        }

    }
}
