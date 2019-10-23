using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Deportivo:Auto,IAfip
    {
        protected int _caballosFuerza;

        public Deportivo(double precio,string patente,int hp):base(precio,patente)
        {
            this._caballosFuerza = hp;
        }

        double IAfip.CalcularImpuesto()
        {
            return this._precio * 0.28;
        }
    }
}
