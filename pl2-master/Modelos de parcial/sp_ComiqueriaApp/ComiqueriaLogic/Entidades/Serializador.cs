using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using ComiqueriaLogic.Comun;

namespace ComiqueriaLogic.Entidades
{
    public class Serializador<T>
    {

        /// <summary>
        /// Guarda datos en un archivo xml
        /// </summary>
        /// <param name="archivo">Ubicación en donde guardar</param>
        /// <param name="datos">Información a guardar</param>
        /// <returns>Retorna falso si hubo alguna excepción</returns>
        public bool GuardarXML(string archivo, T datos)
        {

            Directory.CreateDirectory("outArchivos");

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));

                using (XmlTextWriter xw = new XmlTextWriter("outArchivos/" + archivo, null))
                {
                    s.Serialize(xw, datos);
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException e)
            {
                ComiqueriaException ex = new ComiqueriaException("Error: Directorio no encontrado");
                ArchivoTexto.Escribir(ex.Ruta, ex.Texto, true);
            }
            catch(Exception e)
            {
                throw new Exception("Ocurrió un error, contacte al administrador");
            }

            return true;
        }

        /// <summary>
        /// Lee datos de un archivo xml
        /// </summary>
        /// <param name="archivo">Ubicación a donde guardar</param>
        /// <param name="datos">Información a guardar</param>
        /// <returns>Retorna falso y el dato en null si hubo alguna excepción</returns>
        public bool LeerXML(string archivo, out T datos)
        {
            Directory.CreateDirectory("outArchivos");

            try
            {
                XmlSerializer s = new XmlSerializer(typeof(T));

                using (XmlTextReader xr = new XmlTextReader("outArchivos/" + archivo))
                {
                    datos = (T)s.Deserialize(xr);
                }
            }
            catch (Exception e)
            {
                datos = default(T);
                return false;
            }
            return true;
        }





    }
}
