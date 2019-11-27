using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil:Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;


        #region Constructores

        
        static Automovil()
        {
            Automovil.valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color):base(patente)
        {
            
        }

        public Automovil(string patente, ConsoleColor color, int valorHora):this(patente, color)
        {
            this.color = color;
            Automovil.valorHora = valorHora;
        }

        #endregion

        #region Métodos

        public override string ConsultarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n- Tipo vehículo: Auto");
            sb.AppendFormat("\n- Color: {0}", this.color);
            sb.AppendFormat("\n- Valor hora:{0}", Automovil.valorHora);
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Automovil));
        }

        public override string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}", this.ConsultarDatos());
            sb.AppendFormat("\n{0}", base.ImprimirTicket());
            sb.AppendFormat("\n- Costo de estadía: ${0}", (DateTime.Now.Hour - base.ingreso.Hour) * Automovil.valorHora);

            return sb.ToString();
        }

        #endregion

    }
}
