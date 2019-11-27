using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP
{
    public class Avion : Transporte
    {
        private string aerolinea;

        public string Aerolinea { get => aerolinea; set => aerolinea = value; }

        public override string Transportar()
        {
            return "Corre corre trensito";
        }

        public Avion(int velocidad, string aerolinea)
        {
            this.Velocidad = velocidad;
            this.aerolinea = aerolinea;
        }
    }
}
