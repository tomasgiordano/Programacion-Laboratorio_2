using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public class Avion : Transporte
    {
        private string aerolinea;

        #region Propiedades
        
        public string Aerolinea
        {
            get { return this.aerolinea; }
            set { this.aerolinea = value; }
        }

        #endregion

        #region Constructor

        public Avion(int velocidad, EFabricante fabricante, string aerolinea) : base(fabricante, velocidad)
        {
            this.aerolinea = aerolinea;
        }

        #endregion

        public override string Transportar(Transporte transporte)
        {
            if (transporte != null)
            {
                return "No pudo volar";
            }
            else
            {
                return "Corre corre trensito";
            }
            
        }

        public void EjecutarDelegado()
        {
            EventoTransporte.Invoke(this);
        }

        public event DelegadoTransporte EventoTransporte;




    }
}
