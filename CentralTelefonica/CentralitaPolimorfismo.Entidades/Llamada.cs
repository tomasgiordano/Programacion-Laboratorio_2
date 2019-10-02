using System;
using System.Text;

namespace CentralitaPolimorfismo.Entidades
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLLamada { get; }
        public float Duracion { get { return this._duracion; } }
        public string NroDestino { get {return this._nroDestino; } }
        public string NroOrigen { get {return this._nroOrigen; } }

        public Llamada(string origen,string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroDestino = destino;
            this._nroOrigen = origen;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Origen: ");
            sb.Append(this.NroOrigen);
            sb.Append(" Destino: ");
            sb.Append(this.NroDestino);
            sb.Append(" Duracion: ");
            sb.Append(this.Duracion);

            return sb.ToString();
            
        }

        public static bool operator ==(Llamada uno,Llamada dos)
        {
            
            if (uno.Equals(dos)&&uno.NroDestino==dos.NroDestino&&uno.NroOrigen==dos.NroOrigen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {
            return !(uno == dos);
        }

        public static int OrdenarPorDuracion(Llamada uno,Llamada dos)
        {
            if (uno._duracion > dos._duracion)
            {
                return 1;
            }
            else if (uno._duracion == dos._duracion)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarPorDuracionDes(Llamada uno, Llamada dos)
        {
            if (uno._duracion > dos._duracion)
            {
                return -1;
            }
            else if (uno._duracion == dos._duracion)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
