using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo(string nombre) {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }

        public static bool operator ==(Torneo<T> torneo, T equipo){
            if (torneo.equipos.Contains(equipo)) {
                return true;
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo) {
            if (torneo != equipo) {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public string Mostrar() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nTorneo: {0}", this.nombre);
            sb.Append("\nEquipos:\n");
            foreach (T equipo in this.equipos){
                sb.AppendFormat("\n {0}", equipo.Ficha());
            }
            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2) {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", equipo1.Nombre);
            sb.AppendFormat(" {0}", rnd.Next(0, 10));
            System.Threading.Thread.Sleep(100);
            sb.AppendFormat(" {0}", rnd.Next(0, 10));
            sb.AppendFormat(" {0}", equipo2.Nombre);
            return sb.ToString();
        }

        public string JugarPartido {
            get {
                Random rnd = new Random();
                int rnd1 = rnd.Next(0, this.equipos.Count);
                System.Threading.Thread.Sleep(100);
                int rnd2 = rnd.Next(0, this.equipos.Count);
                while (rnd1 == rnd2) {
                    rnd2 = rnd.Next(0, this.equipos.Count);
                }
                return this.CalcularPartido(this.equipos[rnd1], this.equipos[rnd2]);
            }
        }

    }
}
