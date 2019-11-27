using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    public class Dolar
    {
        #region ATRIBUTOS

        private double cantidad;
        private float cotizRespectoDolar;

        #endregion

        #region CONSTRUCTORES

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {

        }

        public Dolar(double cantidad, float cotizacion)
        {

        }

        #endregion

        #region GETs

        public double GetCantidad()
        {
            return 1;
        }

        public float GetCotizacion()
        {
            return 0;
        }

        #endregion

        #region SOBRECARGAS ENTRE MONEDAS

        public static explicit operator Euro(Dolar d){
            return null;
        }
        public static explicit operator Pesos(Dolar d){
            return null;
        }
        public static implicit operator Dolar(double d){
            return null;
        }

        #endregion

        #region SOBRECARGAS IGUALDAD
        public static bool operator ==(Dolar d, Euro e) {
            return null;
        }
        public static bool operator ==(Dolar d, Pesos p) { }
        public static bool operator !=(Dolar d1, Dolar d2) { }


        public static bool operator !=(Dolar d, Euro e) {
            return null;
        }
        public static bool operator !=(Dolar d, Pesos p) {
            return null;
        }
        public static bool operator !=(Dolar d1, Dolar d2) {
            return null;
        }

        #endregion

        #region SOBRECARGAS RESTA

        public static Dolar operator -(Dolar d, Euro e) {
            return null;
        }

        #endregion

    }
}
