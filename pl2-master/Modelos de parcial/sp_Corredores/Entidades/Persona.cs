using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Persona:Corredor
    {
        #region Atributos
        private string nombre;
        #endregion

        #region Constructores

        public Persona(string nombre, short velocidadMax, ECarril carril) : base(velocidadMax, carril)
        {
            this.nombre = nombre;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Correr deberá ejecutar su código tantas veces como sea necesario,
        /// obteniendo un valor de avance aleatorio y lanzando el evento Corriendo para informar del avance al formulario.
        /// Si lo desean, utilizar System.Threading.Thread.Sleep(300); para una mejor visualización del avance.
        /// </summary>
        public override void Correr()
        {
            while (true)
            {
                Corriendo(Corredor.avance.Next(0, this.VelocidadMax), this);
                System.Threading.Thread.Sleep(300);
            }
        }

        /// <summary>
        /// Guardar guardará y acumulará todos los ganadores del juego. 
        /// En caso de error lanzará la excepción del usuario NoSeGuardoException. 
        /// </summary>
        /// <param name="path"></param>
        public override void Guardar(string path)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path,true))
                {
                    sw.WriteLine(this.ToString());
                }
            }
            catch(Exception e)
            {
                throw new NoSeGuardoException("No se pudo guardar el archivo");
            }
        }

        /// <summary>
        /// Sobreescribir el método ToString para obtener el siguiente texto:
        /// "Juan en carril Carril_1 a una velocidad máxima de 9".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0} en carril {1} a una velocidad máxima de {2}",this.nombre,this.CarrilElegido,this.VelocidadMax);
        }

        #endregion

        #region Eventos

        public delegate void CorrenCallback(int a, Corredor c);

        public event CorrenCallback Corriendo;

        #endregion

    }
}
