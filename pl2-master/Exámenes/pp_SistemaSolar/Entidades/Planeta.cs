using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {

        private int cantSatelites;
        private Tipo tipo;
        private List<Astro> satelites;

        public Planeta(int duraOrbita, int duraRot, string nombre, int cantSatelites, Tipo tipo):this(duraOrbita,duraRot,nombre)
        {
            this.cantSatelites = cantSatelites;
            this.tipo = tipo;
            this.satelites = new List<Astro>();
        }

        public Planeta(int duraOrbita, int duraRotacion, string nombre):base(duraOrbita,duraRotacion,nombre)
        {
            
        }

        public List<Astro> Satelites {
            get {
                return this.satelites;
            }
        }

        /// <summary>
        /// Orbitar() retorna el siguiente mensaje "Orbita el planeta: {nombre}".
        /// </summary>
        /// <returns></returns>
        public override string Orbitar()
        {
            return "Orbita el planeta: " + base.nombre;
        }

        /// <summary>
        /// Rotar() método que no sobreescribe el base. Retorna: "Orbita el planeta {nombre}"
        /// </summary>
        /// <returns></returns>
        public new string Rotar()
        {
            return this.Orbitar();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", base.ToString());
            sb.AppendFormat("\nCant satelites {0}", this.cantSatelites);
            sb.AppendFormat("\nTipo {0}", this.tipo);

            sb.AppendFormat("\nSatelites:");

            for (int i = 0; i < this.Satelites.Count; i++) {
                ((Planeta)this.Satelites[i]).Mostrar(); //TODO
            }
            

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga el operador + para agregar un satélite a la lista, como recibe un objeto 
        /// del tipo Astro debe validar que sea satélite y no planeta.
        /// </summary>
        /// <returns></returns>
        public static bool operator +(Planeta p, Satelite s) {
            if (s is Astro) {
                p.satelites.Add(s);
                return true;
            }
            return false;
        }

        /// Sobrecarga del == (Planeta, Satélite) que chequea si el satélite se encuentra en la lista (comparando el nombre).
        public static bool operator ==(Planeta p, Satelite s) {
            for(int i = 0; i < p.satelites.Count; i++)
            {
                if (p.satelites[i] == s) {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Planeta p, Satelite s){return !(p==s);}

        /// Sobrecarga del == (Planeta, Planeta) compara dos planetas por el nombre.
        public static bool operator ==(Planeta p, Planeta p2) {
            return (p.nombre == p2.nombre);
        }
        public static bool operator !=(Planeta p, Planeta p2){return !(p == p2);}




    }
}
