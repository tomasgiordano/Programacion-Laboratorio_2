using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    public class Fruta
    {
        public float peso;
        public int volumen;
        public ENombresFrutas tipoFruta;
        public enum ENombresFrutas { Manzana,Pera,Banana,Durazno,Kiwi,Naranja,Papaya}


        public Fruta()
        {
            Random r = new Random();

            this.peso = r.Next(1, 5);

            //System.Threading.Thread.Sleep(250);
            this.volumen = r.Next(1, 10);

            //System.Threading.Thread.Sleep(250);
            this.tipoFruta = (ENombresFrutas)r.Next(0, 6);
        }

    }
}
