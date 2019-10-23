using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public class Privado:Avion
    {
        protected int _valoracionServicioDeAbordo;

        public Privado(double precio,double velocidad,int valoracion):base(precio,velocidad)
        {
            this._valoracionServicioDeAbordo = valoracion;
        }
    }
}
