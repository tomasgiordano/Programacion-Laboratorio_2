using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSPyFinal
{
    public class Tren : Transporte
    {
        private string canVagones;

        public Tren(int velocidad, EFabricante fabricante, string cantidadVagones) : base(fabricante, velocidad)
        {
            this.canVagones = cantidadVagones;
        }

        public override string Transportar(Transporte transporte)
        {
            if (transporte != null)
            {
                return "No pudo volar";
            }
            else
            {
                return "Vuela vuela avionsito";
            }
            
        }

        public void EjecutarDelegado()
        {
            EventoTransporte.Invoke(this);
        }

        public event DelegadoTransporte EventoTransporte;


    }
}
