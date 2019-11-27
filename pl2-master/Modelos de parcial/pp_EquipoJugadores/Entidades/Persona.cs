using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {

        #region Fields

        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        
        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Constructores

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }

        #endregion

        #region Métodos

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre: {0}", this.Nombre);
            sb.AppendFormat("\nApellido: {0}", this.Apellido);
            sb.AppendFormat("\nEdad: {0}", this.Edad.ToString());
            sb.AppendFormat("\nDNI: {0}", this.Dni.ToString());
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();

        #endregion

    }
}
