using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic.Entidades;

namespace ComiqueriaLogic.Comun
{
    public class ComiqueriaException:Exception,IArchivoTexto<string>
    {
        /// <summary>
        /// Por defecto
        /// </summary>
        public ComiqueriaException() : base() { }

        /// <summary>
        /// Envia el mensaje personalizado.
        /// </summary>
        /// <param name="mensaje"></param>
        public ComiqueriaException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Envia el mensaje personalizado y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        public ComiqueriaException(string mensaje, string origenError) : base(mensaje)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Envia el mensaje personalizado y la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public ComiqueriaException(string mensaje, Exception innerException) : base(mensaje, innerException) { }

        /// <summary>
        /// Envio el mensaje persoanlziado, la excepción y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        /// <param name="innerException"></param>
        public ComiqueriaException(string mensaje, string origenError, Exception innerException) : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Sobreescritura del toString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen error: " + base.Source;
        }

        public string Ruta
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + "log.txt";
            }
        }

        /// <summary>
        /// Falta agregarle lo de la fecha y eso
        /// </summary>
        public string Texto
        {
            get
            {
                return string.Format("{0} {1} {2}", DateTime.Now.ToString(), base.Message, base.Source);
            }
        }

    }
}
