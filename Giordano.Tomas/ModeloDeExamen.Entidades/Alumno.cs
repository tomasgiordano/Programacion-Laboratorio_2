using System;

namespace ModeloDeExamen.Entidades
{
    public class Alumno
    {
        #region Atributos
        string _apellido;
        int _legajo;
        string _nombre;
        float _nota;
        #endregion

        #region Propiedades

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public float Nota
        {
            get
            {
                return this._nota;
            }
            set
            {
                this._nota = value;
            }
        }

        #endregion

        #region Metodos

        public Alumno(int legajo,string nombre,string apellido)
        {
            this.Legajo = legajo;
            this.Nombre = nombre;
            this.Apellido = apellido;

        }

        public Alumno(int legajo,string nombre,string apellido,float nota):this(legajo,nombre,apellido)
        {
            this.Nota = nota;
        }

        public Alumno(int legajo):this(legajo,"","")
        {
            
        }

        public string Mostrar(Alumno alumno)
        {
            return this._legajo+" "+this._nombre + " " + this._apellido + " " + this._nota;
        }

        private string Mostrar()
        {
            return Mostrar(this);
        }

        public static bool operator ==(Alumno a1,Alumno a2)
        {
            if(!a1.Equals(null) && !a2.Equals(null))
            {
                return a1.Legajo == a2.Legajo;
            }    
            return false;                    
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        #endregion
    }
}
