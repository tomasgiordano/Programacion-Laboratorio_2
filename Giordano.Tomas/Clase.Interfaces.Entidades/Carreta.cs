using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Carreta:Vehiculo,IArba
    {
        public Carreta(double precio):base(precio)
        {

        }

        double IArba.CalcularImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}
