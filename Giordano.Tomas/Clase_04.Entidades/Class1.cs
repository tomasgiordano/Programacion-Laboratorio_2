using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_04.Entidades
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public string Mostrar()
        {
            return this.entero.ToString() + " " + this.cadena + " " + this.fecha.ToString();
        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
            this.entero = -1;
        }

        public Cosa(int entero, string cadena, DateTime fecha):this(cadena,fecha)
        {
            this.entero = entero;
        }

        public Cosa(string cadena, DateTime fecha):this(cadena)
        {
            this.fecha = fecha;
        }

        public Cosa(string cadena):this()
        { 
            this.cadena = cadena;
        }
    }
}
