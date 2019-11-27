using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico:Persona
    {
        #region Fields

        private int añosExperiencia;

        #endregion

        #region Propiedades

        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }

        #endregion

        #region Constructor
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        #endregion

        #region Métodos


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", base.Mostrar());
            sb.AppendFormat("\nAños experiencia: {0}", this.AñosExperiencia.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// ValidarAptitud validará que el Director Técnico sea menor a 65 años y tenga al menos 2 años de
        /// experiencia.
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            if(this.Edad < 65 && this.AñosExperiencia > 2)
            {
                return true;
            }

            return false;
        }

        #endregion

    }
}
