using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase02;

namespace Clase03
{
    class Calculador
    {
        private int _acumulador;

        public Calculador()
        {
            this._acumulador = 0;
        }

        public void acumular(string binario)
        {
            this._acumulador += Conversor.BinarioDecimal(binario);
        }

        public string getResultadoBinario()
        {
            return Conversor.EnteroBinario(this._acumulador);
        }

        public int getResultadoEntero()
        {
            return this._acumulador;
        }
    }
}
