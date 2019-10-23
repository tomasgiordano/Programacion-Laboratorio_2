using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Familia:Auto
    {
        protected int _cantAsientos;

        public Familia(double precio, string patente, int cantidadAsientos):base(precio,patente)
        {
            this._cantAsientos = cantidadAsientos;
        }
    }
}
