using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }

        private int GetIndice(Auto a)
        {
            return this._lista.IndexOf(a);            
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(a);
                return true;
            }
            return false;            
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            if (d.GetIndice(a)!=-1)
            {
                d._lista.Remove(a);
                return true;
            }
            return false;            
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public bool Agregar(Auto a)
        {
            return this + a;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad: ");
            sb.AppendLine(this._capacidadMaxima.ToString());
            sb.AppendLine("Listado de autos: ");
            foreach(Auto actual in this._lista)
            {
                sb.AppendLine(actual.ToString());
            }

            return sb.ToString();
        }
    }
}
