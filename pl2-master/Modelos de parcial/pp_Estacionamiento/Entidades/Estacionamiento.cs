using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>(this.espacioDisponible);
        }

        public Estacionamiento(string nombre, int espacioDisponible):this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        /// <summary>
        /// El operador explícito retornará la información del Estacionamiento y los Vehiculos en su lista. 
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Estacionamiento e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre del estacionamiento: {0}", e.nombre);
            sb.AppendFormat("\nEspacio disponible: {0}", e.espacioDisponible);
            for(int i = 0; i < e.vehiculos.Count; i++)
            {
                sb.AppendFormat("\n{0}", e.vehiculos[i].ImprimirTicket());
            }

            return sb.ToString();    
        }

        /// <summary>
        /// Un Estacionamiento y un Vehiculo será iguales si este último se encuentra dentro de la lista del primero.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (ReferenceEquals(estacionamiento.vehiculos, null))
            {
                return false;
            }

            return estacionamiento.vehiculos.Contains(vehiculo);
        }
        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }


        /// <summary>
        /// Se agregará un Vehiculo a la lista (+) siempre y cuando este
        /// i. No figure previamente en la lista de Vehiculos. 
        /// ii. Tenga una patente asignada
        /// La cantidad de espacio disponible del estacionamiento sea mayor a la cantidad de Vehiculos en la lista.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
                //Ya esta el vehiculo y no tiene una patente
                if( (estacionamiento == vehiculo) && Object.Equals(vehiculo.Patente, null) )
                {
                    return estacionamiento;
                }
                //Si no hay lugar porque hay mas vehiculos que espacio disponible
                else if(estacionamiento.espacioDisponible < estacionamiento.vehiculos.Count)
                {
                    return estacionamiento;
                }
                else
                {
                   estacionamiento.vehiculos.Add(vehiculo);
                }

            return estacionamiento;

        }

        /// <summary>
        /// Al quitar un Vehiculo de la lista se retornará el ticket de cobro mediante el método ImprimirTicket. Caso contrario el método retornará: "El vehículo no es parte del estacionamiento". 
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            string retorno = "";

            if(estacionamiento == vehiculo)
            {
                retorno = vehiculo.ImprimirTicket();
                estacionamiento.vehiculos.Remove(vehiculo);
            }
            else
            {
                retorno = "\nEl vehículo no es parte del estacionamiento\n";
            }


            return retorno.ToString();

        }



    }
}
