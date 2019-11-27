using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Corredor
    {
        #region Atributos

        protected static Random avance;
        private short velocidadMax;
        protected ECarril carrilElegido;
        public enum ECarril {Carril_1, Carril_2}

        #endregion

        #region Propiedades
        /// <summary>
        /// El atributo _carrilElegido será protegido.La propiedad CarrilElegido será de sólo lectura.
        /// </summary>
        public ECarril CarrilElegido
        {
            get
            {
                return this.carrilElegido;
            }
        }
        /// <summary>
        /// La propiedad pública VelocidadMaxima validará que la velocidad máxima nunca podrá superar el valor 10. 
        /// </summary>
        public short VelocidadMax
        {
            get
            {
                return this.velocidadMax;
            }
            set
            {
                if (value <= 10)
                {
                    this.velocidadMax = value;
                }
                else
                {
                    this.velocidadMax = 10;
                }
            }
        }
        #endregion

        #region Constructores

        static Corredor()
        {
            Corredor.avance = new Random(Guid.NewGuid().GetHashCode());
        }
        protected Corredor(short velocidadMax, ECarril carril)
        {
            this.carrilElegido = carril;
            this.VelocidadMax = velocidadMax;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Método abstracto Correr.
        /// </summary>
        public abstract void Correr();

        /// <summary>
        /// Por defecto deberá lanzar la excepción de sistema NotImplementedException.
        /// </summary>
        /// <param name="path"></param>
        public virtual void Guardar(string path)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
