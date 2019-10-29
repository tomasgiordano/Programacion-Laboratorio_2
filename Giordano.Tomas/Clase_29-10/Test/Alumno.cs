using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Alumno:Persona
    {
        public double nota;

        public Alumno():this("","",-1,-1)
        {

        }
        
        public Alumno(string nombre,string apellido,int edad,double nota):base(nombre, apellido, edad)
        {
            this.nota = nota;
        }
        public override string ToString()
        {
            return base.ToString()+" "+this.nota;
        }
    }
}
