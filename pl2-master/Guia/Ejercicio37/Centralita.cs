using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    class Centralita
    {
        #region Fields
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Properties

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }

        #endregion

        #region Builders

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string NombreEmpresa):this()
        {
            this.razonSocial = NombreEmpresa;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Este método recibe un Enumerado TipoLlamada y retornará
        /// el valor de lo recaudado, según el criterio elegido(ganancias por las llamadas del tipo Local,
        /// Provincial o de Todas según corresponda)
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float recaudado = 0;

            //Recorro toda la lista de llamadas
            foreach(Llamada llamada in this.listaDeLlamadas)
            {
                //Fijandome el tipo de llamada: Local, Provincial o Todas
                switch (tipo)
                {
                    //Todo el código restante me lo robé, porque me volví loco trantando y no pude.
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local)
                        {
                            recaudado += ((Local)llamada).CostoLlamada;
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if(llamada is Provincial)
                        {
                            recaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        
                        break;

                    case Llamada.TipoLlamada.Todas:
                        if(llamada is Local)
                        {
                            recaudado += ((Local)llamada).CostoLlamada;
                        }
                        else if(llamada is Provincial)
                        {
                            recaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
            }

            return recaudado;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        /// <summary>
        /// El método Mostrar expondrá la razón social, la ganancia total, ganancia por llamados locales 
        /// y provinciales y el detalle de las llamadas realizadas.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n--------------------------------------------------------------\n");
            sb.AppendFormat("\nRazón social: {0}", this.razonSocial);
            sb.AppendFormat("\nGanancia total: {0}", this.GananciasPorTotal);
            sb.AppendFormat("\nGanancia llamadas locales: {0}", this.GananciasPorLocal);
            sb.AppendFormat("\nGanancia llamadas provinciales: {0}", this.GananciasPorProvincial);

            this.OrdenarLlamadas();

            for(int i = 0; i < this.listaDeLlamadas.Count; i++)
            {
                sb.AppendFormat("{0}", this.listaDeLlamadas[i].Mostrar());
            }

            return sb.ToString();
        }

        #endregion


    }
}
