using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        private int GetIndice(T c)
        {
            return this._lista.IndexOf(c);
        }

        public static bool operator +(Deposito<T> d, T c)
        {
            if (d._lista.Count < d._capacidadMaxima)
            {
                d._lista.Add(c);
                return true;
            }
            return false;
        }

        public static bool operator -(Deposito<T> d, T c)
        {
            if (d.GetIndice(c) != -1)
            {
                d._lista.Remove(c);
                return true;
            }
            return false;
        }

        public bool Agregar(T c)
        {
            return this + c;
        }

        public bool Remover(T c)
        {
            return this - c;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Capacidad: ");
            sb.AppendLine(this._capacidadMaxima.ToString());
            sb.AppendLine("Listado de objetos: ");
            foreach (T c in this._lista)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }


    }
}
