using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SateliteException:Exception
    {
        /// <summary>
        /// Por defecto
        /// </summary>
        public SateliteException() : base() { }

        /// <summary>
        /// Envia el mensaje personalizado.
        /// </summary>
        /// <param name="mensaje"></param>
        public SateliteException(string mensaje) : base(mensaje) { }

        /// <summary>
        /// Envia el mensaje personalizado y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        public SateliteException(string mensaje, string origenError) : base(mensaje)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// Envia el mensaje personalizado y la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public SateliteException(string mensaje, Exception innerException) : base(mensaje, innerException) { }

        /// <summary>
        /// Envio el mensaje persoanlziado, la excepción y la clase que provocó la excepción
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="origenError"></param>
        /// <param name="innerException"></param>
        public SateliteException(string mensaje, string origenError, Exception innerException) : base(mensaje, innerException)
        {
            base.Source = origenError;
        }

        public override string ToString()
        {
            return "No se puede crear el satelite: " + base.Message + ", Origen error: " + base.Source;
        }


    }
}
