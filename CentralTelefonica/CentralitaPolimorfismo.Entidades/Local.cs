using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaPolimorfismo.Entidades
{
    public class Local : Llamada
    {
        protected float _costo;

        public override float CostoLLamada { get { return this.CalcularCosto(); } }

       
        private float CalcularCosto()
        {
            float costo;
            costo = this._costo * this.Duracion;
            return costo;
        }

        public Local(Llamada unaLlamada,float costo):this(unaLlamada.NroOrigen,unaLlamada.Duracion,unaLlamada.NroDestino,costo)
        {
            
        }

        public Local(string origen,float duracion,string destino,float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder(base.Mostrar());
            sb.Append(" Costo LLamada: ");
            sb.Append(this.CostoLLamada);
            sb.Append("\n");
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            if(obj is Local)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
