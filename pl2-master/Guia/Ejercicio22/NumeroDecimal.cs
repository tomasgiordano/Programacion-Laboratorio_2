using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    public class NumeroDecimal
    {
        #region ATRIBUTOS
        public double numero;
        #endregion

        #region CONSTRUCTORES
        private NumeroDecimal(double n)
        {
            this.numero = n;
        }
        #endregion


        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/using-conversion-operators
        #region CONVERSIONES IMPLICITAS
        /// <summary>
        /// Para poder hacer por ejemplo: NumeroDecimal objDecimal = 9;
        /// </summary>
        /// <param name="n">Retorna un objeto de clase NumeroDecimal</param>
        public static implicit operator NumeroDecimal(double n)
        {
            return new NumeroDecimal(n); //Y de acá va al constructor
        }
        #endregion

        #region CONVERSIONS EXPLÍCITAS

        /// <summary>
        /// Para poder hacer: (double)objDecimal
        /// </summary>
        /// <param name="nB"></param>
        public static explicit operator double(NumeroDecimal nD)
        {
            return nD.numero;
        }

        #endregion

        #region MÉTODOS
        /// <summary>
        /// Realiza la suma de un numero decimal y otro binario
        /// </summary>
        /// <param name="nB"></param>
        /// <param name="nD"></param>
        /// <returns>El resultado de la suma en decimal</returns>
        public static double operator +(NumeroDecimal nD, NumeroBinario nB)
        {
            double auxDecimal = Conversor.BinarioDecimal(nB.numero);
            return auxDecimal + nD.numero;
        }

        /// <summary>
        /// Realiza la resta de un numero decimal y otro binario
        /// </summary>
        /// <param name="nB"></param>
        /// <param name="nD"></param>
        /// <returns>El resultado de la resta en decimal</returns>
        public static double operator -(NumeroDecimal nD, NumeroBinario nB)
        {
            double auxDecimal = Conversor.BinarioDecimal(nB.numero);
            return auxDecimal - nD.numero;
        }

        /// <summary>
        /// Chequea si los números son iguales
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si son iguales</returns>
        public static bool operator ==(NumeroDecimal nD, NumeroBinario nB)
        {
            return Conversor.BinarioDecimal(nB.numero) == nD.numero;
        }

        public static bool operator !=(NumeroDecimal nD, NumeroBinario nB)
        {
            return !(nB == nD);
        }
        #endregion

    }
}
