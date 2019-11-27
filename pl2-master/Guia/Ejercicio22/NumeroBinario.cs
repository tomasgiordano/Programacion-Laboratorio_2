using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class NumeroBinario
    {
        #region ATRIBUTOS
        public string numero;
        #endregion

        #region CONSTRUCTOR
        private NumeroBinario(string n)
        {
            this.numero = n;
        }
        #endregion

        #region CONVERSIONES IMPLICITAS
        /// <summary>
        /// Para poder hacer: NumeroBinario objBinario = "1001";
        /// </summary>
        /// <param name="n">Retorna un objeto de clase NumeroBinario</param>
        public static implicit operator NumeroBinario(string n)
        {
            return new NumeroBinario(n); //Y de acá va al constructor
        }
        #endregion

        #region CONVERSIONS EXPLÍCITAS
        /// <summary>
        /// Para poder hacer: (string)objBinario
        /// </summary>
        /// <param name="nB"></param>
        public static explicit operator string(NumeroBinario nB)
        {
            return nB.numero;
        }

        #endregion

        #region MÉTODOS
        /// <summary>
        /// Realiza la suma de un numero decimal y otro binario
        /// </summary>
        /// <param name="nB"></param>
        /// <param name="nD"></param>
        /// <returns>El resultado de la suma en binario</returns>
        public static string operator +(NumeroBinario nB, NumeroDecimal nD)
        {
            double auxDecimal = Conversor.BinarioDecimal(nB.numero);
            return Conversor.DecimalBinario((auxDecimal + nD.numero));
        }

        /// <summary>
        /// Realiza la resta de un numero decimal y otro binario
        /// </summary>
        /// <param name="nB"></param>
        /// <param name="nD"></param>
        /// <returns>El resultado de la resta en binario</returns>
        public static string operator -(NumeroBinario nB, NumeroDecimal nD)
        {
            double auxDecimal = Conversor.BinarioDecimal(nB.numero);
            return Conversor.DecimalBinario((auxDecimal - nD.numero));
        }

        /// <summary>
        /// Chequea si los números son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son iguales</returns>
        public static bool operator ==(NumeroBinario nB, NumeroDecimal nD)
        {
            return Conversor.BinarioDecimal(nB.numero) == nD.numero;
        }

        public static bool operator !=(NumeroBinario nB, NumeroDecimal nD)
        {
            return !(nB == nD);
        }
        #endregion

    }
}
