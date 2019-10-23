using System;

namespace Clase.Interfaces.Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public void MostrarPrecio()
        {
            Console.WriteLine("PRECIO: "+this._precio.ToString());
        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }
    }
}
