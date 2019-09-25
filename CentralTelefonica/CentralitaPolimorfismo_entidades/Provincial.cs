using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfismo_entidades
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public override float CostoLLamada{ get; }

        public float Duracion
        {
            get;
        }

        private float CalcularCosto()
        {

        }

        public bool Equals(object obj)
        {

        }

        protected override string Mostrar()
        {
            return base.Mostrar()+" "+this._franjaHoraria.ToString();
        }

        public Provincial(Franja miFranja, Llamada unallamada):this(unallamada.NroOrigen,miFranja,unallamada.Duracion,unallamada.NroDestino)
        {
            
        }

        public Provincial(string origen,Franja miFranja,float duracion,string destino):base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
