using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Avion:Vehiculo,IAfip,IArba
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

        double IArba.CalcularImpuesto()
        {
            if(this is Comercial)
            {
                return this._precio * 0.25; 

            }
            else
            {
                return this._precio * 27;
            }
        }
    }
}
