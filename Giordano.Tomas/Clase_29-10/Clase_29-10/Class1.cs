using System;

namespace Clase_29_10
{
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido;
        }
    }
}
