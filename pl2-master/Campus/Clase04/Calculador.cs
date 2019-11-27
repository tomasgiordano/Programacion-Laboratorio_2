using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    class Calculador
    {
        #region Atributos

        private int _acumulador;

        #endregion Atributos

        #region Constructores

        public Calculador()
        {
            this._acumulador = 0;
        }

        public Calculador(int valorInicial)
        {
            this._acumulador = valorInicial;
        }

        public Calculador(string valorInicial) : this(Conversor.BinarioDecimal(valorInicial))
        {

        }

        #endregion Constructores

        #region Métodos

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

        public void acumular(int numero)
        {
            this._acumulador += numero;
        }

        #endregion Métodos

    }
}
