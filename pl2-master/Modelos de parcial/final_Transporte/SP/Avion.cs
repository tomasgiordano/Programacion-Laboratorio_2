using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP;

namespace SP
{
    public class Tren : Transporte
    {
        private string aerolinea;

        public string Aerolinea { get => aerolinea; set => aerolinea = value; }

        public override string Transportar()
        {
            return "Vuela vuela avionsito";
        }

        public Tren(int velocidad, string aerolinea)
        {
            this.Velocidad = velocidad;
            this.aerolinea = aerolinea;
        }
    }
}
