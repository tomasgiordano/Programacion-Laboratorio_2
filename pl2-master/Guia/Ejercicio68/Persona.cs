using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public Persona() {
            this.Nombre = "Fulano";
            this.Apellido = "Mengano";
        }

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public string Mostrar() {
            return this.Nombre + " , " + this.Apellido;
        }

        
        

    }
}
