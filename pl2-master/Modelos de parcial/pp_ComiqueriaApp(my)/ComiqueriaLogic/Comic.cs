using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic:Producto
    {
        #region Campos
        public enum TipoComic
        {
            Occidental, Oriental
        }
        private string autor;
        private TipoComic tipoComic;
        #endregion

        #region Constructor

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic):base(descripcion,stock,precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Devuelve la información del comic
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", base.ToString());
            sb.AppendFormat("\n\n- Autor: {0}", this.autor);
            sb.AppendFormat("\n- Tipo del comic: {0}", this.tipoComic);
            return sb.ToString();
        }

        #endregion
    }
}
