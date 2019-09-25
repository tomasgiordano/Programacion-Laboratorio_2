using System;

namespace CentralitaPolimorfismo_entidades
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLLamada{ get; }

        public float Duracion
        {
            get { return this._duracion; }
        }
        public string NroDestino
        {
            get { return this._nroDestino; }
        }
        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }
            
        protected virtual string Mostrar()
        {
            return this._nroOrigen.ToString() + " " + this._nroDestino.ToString() + " " + this._duracion.ToString();
        }

        public static bool operator ==(Llamada uno,Llamada dos)
        {
            bool aux = false;
            if(uno._nroDestino==dos._nroDestino&&uno._nroOrigen==dos._nroOrigen)
            {
                aux = true;
            }

            return aux;
        }

        public static bool operator !=(Llamada uno, Llamada dos)
        {

            return !(uno == dos);
        }

        public int OrdenarPorLlamada(Llamada uno, Llamada dos)
        {
            
            if(uno._duracion>dos._duracion)
            {
                return 1;
            }else if(uno._duracion < dos._duracion)
            {
                return -1;
            }
            return 0;
        }
    }
}
