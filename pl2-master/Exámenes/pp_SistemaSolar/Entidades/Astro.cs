using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Astro
    {
        private int duracionOrbita;
        private int duracionRotacion;
        protected string nombre;

        /// <summary>
        ///  Un constructor que recibe su nombre y la duración de órbita y la de rotación
        /// </summary>
        /// <param name="duraOrbita"></param>
        /// <param name="duraRotacion"></param>
        /// <param name="nombre"></param>
        public Astro(int duraOrbita, int duraRotacion, string nombre) {
            this.duracionOrbita = duraOrbita;
            this.duracionRotacion = duraRotacion;
            this.nombre = nombre;
        }

        /// <summary>
        ///  Método protegido que devuelve toda la información del astro.
        /// </summary>
        /// <returns></returns>
        protected string Mostrar() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuracion orbita: {0}", this.duracionOrbita);
            sb.AppendFormat("\nDuracion rotacion: {0}", this.duracionRotacion);
            sb.AppendFormat("\nNombre: {0}", this.nombre);
            return sb.ToString();
        }

        /// <summary>
        /// Orbitar() método abstracto
        /// </summary>
        /// <returns></returns>
        public abstract string Orbitar();

        /// <summary>
        /// Rotar() método virtual que retorna el mensaje  
        /// </summary>
        /// <returns>"Rotando. Tiempo estimado: {tiempo de rotación}."</returns>
        public virtual string Rotar() {
            return "Rotando. Tiempo Estimado: {0}" + this.duracionOrbita;
        }

        /// <summary>
        /// Conversor explícito de Astro a String que retorne sólo el nombre del astro.
        /// </summary>
        public static explicit operator string(Astro a) {
            return a.nombre;
        }





    }
}
