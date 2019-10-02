using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfismo.Entidades
{
    public class Provincial : Llamada
    {
        protected Franja _franjaHoraria;

        public Provincial(Franja miFranja, Llamada unaLlamada) : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        
        public override float CostoLLamada
        {
            get { return this.CalcularCosto(); }
        }
        /// <summary>
        /// HACER CALCULAR COSTO
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            float costo=0;
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = Convert.ToSingle(0.99 * base.Duracion);
                    break;

                case Franja.Franja_2:
                    costo = Convert.ToSingle(1.25 * base.Duracion);
                    break;

                case Franja.Franja_3:
                    costo = Convert.ToSingle(0.66 * base.Duracion);
                    break;
            }

            return costo;
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.Append(" Franja Horaria: ");
            sb.Append(this._franjaHoraria);
            sb.Append(" Costo de llamada: ");
            sb.Append(this.CostoLLamada);
            sb.Append("\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }



    }


     
}

