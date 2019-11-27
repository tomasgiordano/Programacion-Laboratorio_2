using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Aeropuerto<T>
    {
        private List<T> vuelos;

        public Aeropuerto()
        {

        }

        public static explicit operator String(Aeropuerto<T> a)
        {
            return String.Format("El aeropuerto cuenta con {0} vuelos en estado Volando",a.vuelos.Count);
        }

        public void FinalizarVuelos()
        {
            
        }

        /// <summary>
        /// Agregará un vuelo a la lista y retornará a.vuelos.Count * 50
        /// </summary>
        /// <param name="a"></param>
        /// <param name="vuelo"></param>
        /// <returns></returns>
        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count*50;
        }



    }
}
