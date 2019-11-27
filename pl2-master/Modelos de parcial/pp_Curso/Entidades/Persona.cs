using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string documento;

        public String Nombre { get { return this.nombre; } }
        public String Apellido { get { return this.apellido; } }
        public String Documento {
            get { return this.documento; }
            set { this.documento = value; }
        }

        public Persona(string nombre, string apellido, string documento) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public virtual String ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n\nNombre: {0}", this.Nombre);
            sb.AppendFormat("\nApellido: {0}", this.Apellido);
            sb.AppendFormat("\nDocumento: {0}", this.Documento);
            return sb.ToString();
        }

        public abstract bool ValidarDocumentacion(string doc);
        
    }
}
