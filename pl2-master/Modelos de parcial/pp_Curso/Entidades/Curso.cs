using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnosList;
        private short anio;
        private Divisiones division;
        private Profesor profesor;

        public string AnioDivision {
            get { return this.anio.ToString() + "º" + this.division.ToString(); }
        }

        private Curso() {
            this.alumnosList = new List<Alumno>();
        }

        public Curso(short anio, Divisiones division, Profesor profesor) : this() {
            this.anio = anio;
            this.division = division;
            this.profesor = profesor;
        }

        public static explicit operator string(Curso c){
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\nInformación del profesor: {0}", c.profesor.ExponerDatos());
            sb.AppendFormat("\nDivisión: {0}", c.AnioDivision);

            if (c.alumnosList.Count != 0)
            {
                foreach (Alumno a in c.alumnosList)
                {
                    if (c == a)
                    {
                        sb.AppendFormat("{0}", a.ExponerDatos());
                    }
                }
            }
            else {
                sb.AppendFormat("\n Este curso no tiene alumnos");
            }

            return sb.ToString();
        }

        /// <summary>
        /// El operador + entre Curso y Alumno agregará al alumno al curso
        /// siempre y cuando su Año y Divisióncoincidan.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Curso operator +(Curso c, Alumno a) {
            if (c == a) {
                c.alumnosList.Add(a);
            }
            return c;
        }

        /// <summary>
        /// El operador == entre Curso y Alumno informará true
        /// si el alumno pertenece al mismo Año y División que el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Curso c, Alumno a) {
            return c.AnioDivision == a.AnioDivision;
        }
        public static bool operator !=(Curso c, Alumno a){
            return !(c == a);
        }



    }
}
