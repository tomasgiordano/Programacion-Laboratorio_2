using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
		public string Nombre {
            get { return base.nombre; }
        }

        public Satelite(int duraOrbita, int duraRotacion, string nombre):base(duraOrbita,duraRotacion,nombre) {

        }

        public override string Orbitar()
        {
           return "Orbitar el satelite: " + this.Nombre;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
