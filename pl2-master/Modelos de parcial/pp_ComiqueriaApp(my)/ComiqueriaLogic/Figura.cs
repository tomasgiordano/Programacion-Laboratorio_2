using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura:Producto
    {
        #region Campos
        private double altura;
        #endregion

        #region Constructores NEW

        /// <summary>
        /// no recibe descripción. En su lugar inicializará ese campo con el siguiente texto "Figura *altura* cm"
        /// donde* altura* corresponde al valor de la altura de la figura.
        /// </summary>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="altura"></param>
        public Figura(int stock, double precio, double altura) : this("Figura " + altura.ToString() + "cm", stock, precio,altura)
        {
            
            
        }
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }

        #endregion

        #region Constructores OLD

        // /// <summary>
        // /// no recibe descripción. En su lugar inicializará ese campo con el siguiente texto "Figura *altura* cm"
        // /// donde* altura* corresponde al valor de la altura de la figura.
        // /// </summary>
        // /// <param name="stock"></param>
        // /// <param name="precio"></param>
        // /// <param name="altura"></param>
        //public Figura(int stock, double precio, double altura):base("Figura "+altura.ToString()+"cm",stock,precio)
        //{
        //    this.altura = altura;
        //}
        //public Figura(string descripcion, int stock, double precio, double altura):base(descripcion,stock,precio)
        //{
        //    this.altura = altura;
        //}

        #endregion

        #region Métodos
        /// <summary>
        /// Sobrescribir el método ToString. Agregar a lo devuelto por el ToString de la clase base los
        /// datos de la Figura(Altura). Seguir el mismo formato y metodología utilizado en la clase base.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", base.ToString());
            sb.AppendFormat("\n- Altura:{0}", this.altura);
            return sb.ToString();
        }
        #endregion
    }
}
