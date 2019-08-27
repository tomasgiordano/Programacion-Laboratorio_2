using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void CalcularFinal()
        {
            Random rnd = new Random();

            if(this.nota1>=4&&this.nota2>=4)
            {
                this.notaFinal=(float)rnd.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte nota1,byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            if(this.notaFinal!=-1)
            {
                return this.nombre + " " + this.apellido + " Nota1: " + this.nota1.ToString() + " / Nota2: " + this.nota2.ToString() + " / NotaFinal: " + this.notaFinal;
            }
            else
            {
                return this.nombre + " " + this.apellido + " Nota1: " + this.nota1.ToString() + " / Nota2: " + this.nota2.ToString() + " / ALUMNO DESAPROBADO ";
            }
        }

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
    }
}
