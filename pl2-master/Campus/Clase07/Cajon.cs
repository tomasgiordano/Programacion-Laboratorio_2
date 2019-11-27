using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    public class Cajon
    {
        private List<Fruta> frutas;
        //Indica el espacio total del cajón
        private int volumen;

        private Cajon()
        {
            this.frutas = new List<Fruta>();
        }

        public Cajon(int i):this()
        {
            this.volumen = i;
        }

        public int CalcularEspacioDisponible()
        {
            int aux = 0;

            for (int i = 0; i < this.frutas.Count; i++)
            {
                aux += this.frutas[i].volumen;
            }

            return this.volumen - aux;
        }

        public string MostrarContenido()
        {

            int aux = 0;

            for (int i = 0; i < this.frutas.Count; i++)
            {
                aux += this.frutas[i].volumen;
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Volumen ocupado del cajón: {0}", aux);
            sb.AppendFormat("\nVolumen total del cajón: {0}", this.volumen);
            sb.AppendFormat("\nVolumen libre del cajón: {0}", this.CalcularEspacioDisponible());

            sb.AppendFormat("\n\nLista de frutas:");

            for (int i = 0; i < this.frutas.Count; i++)
            {
                sb.AppendFormat("\nFruta: {0}", this.frutas[i].tipoFruta);
                sb.AppendFormat("\nPeso: {0}", this.frutas[i].peso);
                sb.AppendFormat("\nVolumen: {0}\n", this.frutas[i].volumen);
            }

            return sb.ToString();
        }


        public bool AgregarFruta(Fruta f)
        {
            if (this.CalcularEspacioDisponible() - f.volumen >= 0)
            {
                this.frutas.Add(f);
                return true;
            }
            return false;
        }


        public bool QuitarFruta()
        {
            if(this.frutas.Count > 0)
            {
                Random r = new Random();
                this.frutas.RemoveAt(r.Next(0, this.frutas.Count));
                return true;
            }
            return false;
        }


    }
}
