using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDeExamen.Entidades
{
    class Materia
    {
        List<Alumno> _alumnos;
        EMateria _nombre;
        static Random _notaParaUnAlumno;

        List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        EMateria Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        private Materia()
        {
            this.Alumnos = new List<Alumno>();
        }

        private Materia(EMateria nombre) : this()
        {
            this.Nombre = nombre;
        }

        static Materia()
        {
            Materia._notaParaUnAlumno = new Random();
        }

        private string Mostrar()
        {
            return "Materia: " + this.Nombre + "\n**********************ALUMNOS**********************/n***************************************************";
        }

        public void CalificarAlumnos()
        {
            foreach (Alumno a in this.Alumnos)
            {
                a.Nota = _notaParaUnAlumno.Next(1, 10);
            }
        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }

        public static implicit operator float(Materia m)
        {
            float acumulador = 0;

            foreach (Alumno a in m.Alumnos)
            {
                acumulador = a.Nota + acumulador;
            }

            return (float)(acumulador / m.Alumnos.Count);
        }

        public static implicit operator Materia(EMateria nombre)
        {
            return new Materia(nombre);
        }

        public static bool operator ==(Materia m, Alumno a)
        {
            if (!m.Equals(null))
            {
                return m.Alumnos.Contains(a);
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }
     }
  
}
