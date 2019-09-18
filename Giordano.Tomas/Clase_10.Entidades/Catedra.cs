using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_10.Entidades
{
    class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> GetAlumnos
        {
            get { return this.alumnos; }
        }

        public static int operator |(Catedra c, Alumno a)
        {
            return c.GetAlumnos.IndexOf(a);
        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            return c.GetAlumnos.Contains(a);
        }

        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c == a);
        }

        public static bool operator +(Catedra c, Alumno a)
        {
            if (c == a)
            {
                return false;
            }
            else
            {
                c.GetAlumnos.Add(a);
                return true;
            }
        }

        public static bool operator -(Catedra c,Alumno a)
        {
            if(c==a)
            {
                c.GetAlumnos.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}