using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase._13._11
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        public event LimiteSueldoDelegado limiteSueldo;
        public event LimiteSueldoMejoradoDel limiteMejorado;



        public Empleado(string nombre, string apellido, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public string Nombre { get {return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get {return this.apellido; } set {this.apellido=value; } }
        public int Legajo { get {return this.legajo; } set {this.legajo=value; } }
        public double Sueldo
        {
            get {
                return this.sueldo;
            }
            set {
                if (value >= 30000)
                {
                    try
                    {
                        this.limiteMejorado(this, new EmpleadoEventArgs());
                    }
                    catch(Exception e)
                    {
                        
                    }
                }
                else if (value > 18000 && value < 30000)
                {
                    try
                    {
                        this.limiteSueldo(value, this);
                    }
                    catch(Exception e)
                    {

                    }
                }               
                else
                {
                    this.sueldo = value;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("NOMBRE COMPLETO: ");
            sb.Append(this.Nombre);
            sb.Append(" ");
            sb.AppendLine(this.Apellido);
            sb.Append("LEGAJO: ");
            sb.AppendLine(this.Legajo.ToString());
            sb.Append("SUELDO: ");
            sb.AppendLine(this.Sueldo.ToString());

            return sb.ToString();
        }

        

    }
}
