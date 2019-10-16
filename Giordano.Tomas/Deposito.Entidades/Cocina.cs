using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get {return this._codigo; } }
        public bool EsIndustrial { get{return this._esIndustrial; }}
        public double Precio { get {return this._precio; } }

        public Cocina(int codigo,double precio,bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;            
        }

        public override bool Equals(object obj)
        {
            if(this is Cocina&& this == (Cocina)obj)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Cocina a,Cocina b)
        {
            return a.Codigo == b.Codigo;
        }
        public static bool operator !=(Cocina a,Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Codigo: ");
            sb.Append(this.Codigo.ToString());
            sb.Append(" - ");
            sb.Append("Es Industrial: ");
            sb.Append(this.EsIndustrial.ToString());
            sb.Append(" - ");
            sb.Append("Precio: ");
            sb.Append(this.Precio.ToString());

            return sb.ToString();
        }


    }
}
