using ComiqueriaLogic.Persistencia_de_Datos;
using System;
using System.Text;

namespace ComiqueriaLogic
{
    class ComiqueriaException : Exception, IArchivoTexto
    {
        public ComiqueriaException(string message, Exception innerException) : base(message, innerException)
        {
            ArchivoTexto.Escribir(this, true);
        }

        public string Texto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(DateTime.Now.ToString() + ":");
                sb.AppendLine(this.Message);
                Exception innerException = this.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

                return sb.ToString();
            }
        }

        public string Ruta
        {
            get
            {
                return String.Format("{0}log.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }
        }
    }
}
