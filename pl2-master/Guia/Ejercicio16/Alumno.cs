using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio16
{
    class Alumno
    {
        #region ATRIBUTOS
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public string nombre;
        public string apellido;
        public int legajo;
        #endregion

        #region CONSTRUCTORES
        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        #endregion

        #region MÉTODOS
        public void CalcularFinal()
        {
            if(this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random n = new Random();
                Thread.Sleep(1000);
                this._notaFinal = n.Next(1,10);
            }
            else
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public string Mostrar()
        {
            if(this._notaFinal != -1)
            {
                return "Nota 1: " + this._nota1.ToString() + " Nota 2: " + this._nota2.ToString() + " Nota final: " + this._notaFinal.ToString();
            }
            else
            {
                return "Alumno desaprobado";
            }
            
        }
        #endregion

    }
}
