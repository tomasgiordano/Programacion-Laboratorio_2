using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Empleado:Persona
    {
        public int legajo;
        public double sueldo;

        public override string ToString()
        {
            return base.ToString()+" "+this.sueldo+" "+this.legajo;
        }

        public Empleado():this("", "", -1, -1,-1)
        {

        }

        public Empleado(string nombre, string apellido, int edad, double sueldo,int legajo):base(nombre, apellido, edad)
        {
            this.sueldo = sueldo;
            this.legajo = legajo;
        }
    }
}
