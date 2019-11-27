using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio47
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion) {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre {
            get {
                return this.nombre;
            }
        }

        public static bool operator ==(Equipo e1, Equipo e2) {
            if (e1.nombre == e2.nombre) {
                if (e1.fechaCreacion == e2.fechaCreacion) {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2) {
            return !(e1 == e2);
        }

        public string Ficha() {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", this.nombre);
            sb.Append(" fundado el ");
            sb.AppendFormat("{0}", this.fechaCreacion);
            return sb.ToString();
        }

    }
}
