using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Avion:Vehiculo,IAfip
    {
        protected double _velocidadMaxima;

        public Avion(double precio,double velMax):base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        double IAfip.CalcularImpuesto()
        {
            return this._precio * 0.33;
        }
    }
}
