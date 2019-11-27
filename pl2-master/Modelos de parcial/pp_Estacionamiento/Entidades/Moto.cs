using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto:Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        #region Constructores


        static Moto()
        {
            Moto.valorHora = 30;
        }

        public Moto(string patente, int cilindrada) : base(patente)
        {
            this.cilindrada = cilindrada;
        }

        public Moto(string patente, int cilindrada, short ruedas) : this(patente, cilindrada)
        {
            this.ruedas = 2; // = ruedas;
        }

        public Moto(string patente, int cilindrada, short ruedas, int valorHora):this(patente, cilindrada, 2)
        {
            Moto.valorHora = valorHora;
        }

        #endregion


        #region Métodos

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n- Tipo vehículo: Moto");
            sb.AppendFormat("\n- Cilindros:{0}", this.cilindrada);
            sb.AppendFormat("\n- Ruedas:{0}", this.ruedas);
            sb.AppendFormat("\n- Valor hora:{0}", Moto.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Moto));
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", this.ConsultarDatos());
            sb.AppendFormat("\n{0}", base.ImprimirTicket());
            sb.AppendFormat("\n- Costo de estadía: ${0}", (DateTime.Now.Hour - base.ingreso.Hour) * Moto.valorHora);

            return sb.ToString();
        }

        #endregion


    }
}
