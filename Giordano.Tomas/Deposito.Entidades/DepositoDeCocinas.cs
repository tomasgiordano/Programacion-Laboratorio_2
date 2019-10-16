using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }

        private int GetIndice(Cocina c)
        {
            return this._lista.IndexOf(c);
        }

        public static bool operator +(DepositoDeCocinas d,Cocina c)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            if (d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                return true;
            }
            return false;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad: ");
            sb.AppendLine(this._capacidadMaxima.ToString());
            sb.AppendLine("Listado de cocinas: ");
            foreach(Cocina c in this._lista)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }
    }
}
