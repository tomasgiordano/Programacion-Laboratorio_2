using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Provincial:Llamada
    {
        #region Fields
        public enum Franja
        {
            Franja_1, Franja_2, Franja_3
        }
        protected Franja franjaHoraria;
        #endregion

        #region Properties

        public float CostoLlamada { get { return CalcularCosto(); } }

        #endregion

        #region Builder
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion

        #region Methods

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return ((float)0.99 * this.Duracion);
                case Franja.Franja_2:
                    return ((float)1.25 * this.Duracion);
                case Franja.Franja_3:
                    return ((float)0.66 * this.Duracion);
            }
            return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", base.Mostrar());
            sb.AppendFormat("\nCosto de llamada: {0}", this.CostoLlamada);
            sb.AppendFormat("\nFranja horaria: {0}", this.franjaHoraria);
            return sb.ToString();
        }
        #endregion

    }
}
