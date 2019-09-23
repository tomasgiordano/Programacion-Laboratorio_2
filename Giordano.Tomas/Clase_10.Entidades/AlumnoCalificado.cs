using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
    public class AlumnoCalificado:Alumno
    {
        protected double nota;

        public double GetNota
        {
            get { return this.nota; }
        }

        public AlumnoCalificado(Alumno a,double nota):this(a.GetNombre,a.GetApellido,a.GetLegajo,a.GetExamen,nota)
        {
            
        }

        public AlumnoCalificado(string nombre,string apellido,int legajo,ETipoExamen examen,double nota):base(nombre,apellido,legajo,examen)
        {
            this.nota = nota;
        }

        public string Mostrar()
        {
            return Alumno.Mostrar(this) +" "+ this.nota.ToString();
        }
    }
}
