using System;

namespace Clase_10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string GetApellido
        {
            get { return this.apellido; }
        }

        public static string Mostrar(Alumno a)
        {
            return a.nombre + " " + a.apellido + " " + a.legajo.ToString() + " " + a.examen; 
        }

        public ETipoExamen GetExamen
        {
            get { return this.examen; }
        }

        public int GetLegajo
        {
            get{ return this.legajo; }
        }

        public string GetNombre
        {
            get { return this.nombre; }
        }

        public Alumno(string nombre,string apellido,int legajo,ETipoExamen examen)
        {
            this.nombre = nombre;
            this.examen = examen;
            this.legajo = legajo;
            this.apellido = apellido;
        }

        public static bool operator ==(Alumno a,Alumno b)
        {
            if((a.nombre==b.nombre)&&(a.apellido==b.apellido)&&(a.examen==b.examen)&&(a.legajo==b.legajo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Alumno a,Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorApellidoAsc(Alumno a,Alumno b)
        {
            return string.Compare(a.apellido, b.apellido);
        }
        
        public static int OrdenarPorApellidoDesc(Alumno a,Alumno b)
        {
            return -1 * string.Compare(a.apellido, b.apellido);
        }

        public static int OrdenarPorLegajoAsc(Alumno a,Alumno b)
        {
            if(a.legajo==b.legajo)
            {
                return 0;   
            }
            else if(a.legajo>b.legajo)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarPorLegajoDesc(Alumno a,Alumno b)
        {
            return -1 * OrdenarPorLegajoAsc(a, b);
        }
    }
}
