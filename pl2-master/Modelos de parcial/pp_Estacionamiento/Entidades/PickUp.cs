using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp:Vehiculo
    {
        private string modelo;
        private static int valorHora;

        #region Constructores


        static PickUp()
        {
            PickUp.valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {

        }

        public PickUp(string patente, string modelo, int valorHora) : this(patente, modelo)
        {
            this.modelo = modelo;
            PickUp.valorHora = valorHora;
        }

        #endregion


        #region Métodos

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n- Tipo vehículo: PickUp");
            sb.AppendFormat("\n- Modelo: {0}", this.modelo);
            sb.AppendFormat("\n- Valor hora:{0}", PickUp.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(PickUp));
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("\n{0}", this.ConsultarDatos());
            sb.AppendFormat("\n{0}", base.ImprimirTicket());
            sb.AppendFormat("\n- Costo de estadía: ${0}", (DateTime.Now.Hour - base.ingreso.Hour) * PickUp.valorHora);

            return sb.ToString();
        }

        #endregion

    }
}
