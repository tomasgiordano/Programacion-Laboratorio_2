using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad{
            get {
                return (int)(DateTime.Now-this.fechaIngreso.Date).TotalDays;
            }
        }

        public Profesor(string n, string a, string d):base(n,a,d){}

        public Profesor(string n, string a, string d, DateTime f):this(n,a,d) {
            this.fechaIngreso = f;
        }

        public override string ExponerDatos(){
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExponerDatos());
            sb.AppendFormat("Antigüedad: {0}", this.Antiguedad);
            return sb.ToString();
        }

        /// <summary>
        /// Dará como válido cuando el documento tenga exactamente 8 caracteres.
        /// </summary>
        /// <param name="doc"></param>
        /// <returns></returns>
        public override bool ValidarDocumentacion(string doc){
            return doc.Length == 8;
        }
    }
}
