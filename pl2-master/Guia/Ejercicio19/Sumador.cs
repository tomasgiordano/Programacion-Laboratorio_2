using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        #region ATRIBUTOS
        private int _cantidadSumas;
        #endregion

        #region PROPIEDADES
        public int CantidadSumas
        {
            get
            {
                return this._cantidadSumas;
            }
            set
            {
                if (value == 1)
                {
                    this._cantidadSumas += value;
                }
            }
        }
        #endregion

        #region CONSTRUCTORES
        public Sumador() : this(0)
        {

        }
        public Sumador(int cantidadSumas)
        {
            this._cantidadSumas = cantidadSumas;
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        ///  incrementará cantidadSumas en 1 y sumará valores numericos
        /// </summary>
        /// <param name="a">numero</param>
        /// <param name="b">numero</param>
        /// <returns>Resultado de la suma de los valores numericos</returns>
        public long Sumar(long a, long b)
        {
            CantidadSumas = 1;
            return a + b;
        }
        /// <summary>
        ///  concatenará las cadenas de texto.
        /// </summary>
        /// <param name="a">cadena</param>
        /// <param name="b">cadena</param>
        /// <returns>Cadenas concatenadas</returns>
        public string Sumar(string a, string b)
        {
            CantidadSumas = 1;
            return a + b;
        }
        #endregion

        #region SOBRECARGAS
        /// <summary>
        /// Conversión explícita que retorne cantidadSumas
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s._cantidadSumas;
        }

        /// <summary>
        ///  para que puedan sumar cantidadSumas
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>retornen un long con dicho valor.</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1._cantidadSumas + s2._cantidadSumas;
        }

        /// <summary>
        /// ambos sumadores tienen igualcantidadSumas.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns> retorne True si ambos sumadores tienen igual cantidadSumas</returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1._cantidadSumas == s2._cantidadSumas;
        }


        #endregion


    }
}
