using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Fields

        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        #endregion

        #region Propiedades

        /// <summary>
        /// La propiedad DirectorTecnico será utilizada para asignar un director técnico al equipo siempre y
        /// cuando cumpla con las condiciones de aptitud.
        /// </summary>
        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }
                else
                {
                    this.directorTecnico = null;
                }
                
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        #endregion

        #region Constructores
        private Equipo()
        {
            this.jugadores = new List<Jugador>(cantidadMaximaJugadores);
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Método de clase que retorna true en caso de que un equipo sea válido, para lo cual
        ///debe cumplir con las siguientes condiciones:
        /// i.Tener un Director Técnico asignado. done
        /// ii.Tener al menos un jugador de c/posición.
        /// iii.Tener sólo 1 arquero. done
        /// iv.Cumplir con la cantidad de integrantes completa(la cantidad de jugadores agregados a la
        /// lista debe ser igual a la constante “cantidadMaximaJugadores”). done
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ValidarEquipo(Equipo e)
        {
            int contArquero = 0;
            //Director tecnico y cantidad igual a la constante
            if( ReferenceEquals(e.directorTecnico, null) || e.jugadores.Count != cantidadMaximaJugadores)
            {
                return false;
            }

            for(int i = 0; i < e.jugadores.Count; i++)
            {
                if(e.jugadores[i].Posicion == Posicion.Arquero)
                {
                    contArquero++;
                }
            }

            if(contArquero != 1)
            {
                return false;
            }

            //Manera mala
            //Arquero, Defensor, Central, Delantero
            int cantDefensor = 0;
            int cantCentral = 0;
            int cantDelantero = 0;

            for(int i = 0; i< e.jugadores.Count; i++)
            {
                if(e.jugadores[i].Posicion == Posicion.Defensor)
                {
                    cantDefensor++;
                }
                if(e.jugadores[i].Posicion == Posicion.Delantero)
                {
                    cantDelantero++;
                }
                if(e.jugadores[i].Posicion == Posicion.Central)
                {
                    cantCentral++;
                }
            }

            if((cantCentral>=1 && cantDefensor>=1) && cantDelantero >= 1)
            {
                return true;
            }

            return false;
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// El operador explícito retornará los datos del equipo, su director técnico (en caso de no tener uno
        /// asignado aún, mostrar en su lugar el string "Sin DT asignado") y todos sus jugadores, utilizando
        /// StringBuilder para compilar dicha información.
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator string(Equipo e)
        {
            string elDt = "";

            if(ReferenceEquals(e.directorTecnico, null))
            {
                elDt = "Sin DT asignado";
            }
            else
            {
                elDt = e.directorTecnico.Mostrar();
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nNombre del equipo: {0}", e.Nombre);
            sb.AppendFormat("\nDirector técnico: {0}", elDt);
            sb.AppendFormat("\n\nLista de jugadores:");
            for (int i = 0; i < e.jugadores.Count; i++)
            {
                sb.AppendFormat("\n{0}", e.jugadores[i].Mostrar());
            }

            

            return sb.ToString();
        }


        /// <summary>
        ///  El operador + entre Equipo y Jugador agregará el jugador al equipo siempre y cuando:
        ///i.Este no haya sido agregado aún.
        ///ii.No haya sido superada la cantidad de integrantes.
        ///iii.Cumpla las condiciones de aptitud.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static Equipo operator +(Equipo e, Jugador j)
        {

            //Reviso si ya existe, usando la sobrecarga ' == '
            if (e == j)
            {
                return e;
            }

            //Valido aptitud y si hay lugar para agregarlo
            if (j.ValidarAptitud() && e.jugadores.Count < cantidadMaximaJugadores)
            {
                e.jugadores.Add(j);
            }

            //e.jugadores.Add(j); //Me olvidé de sacar esto, puedo ser tan pelotudo viejo?

            return e;
        }

        /// <summary>
        /// El operador == entre Equipo y Jugador informará true si esa instancia de Jugador ya se encuentra 
        /// agregada al equipo.
        /// </summary>
        /// <param name="e"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            #region Con Contains
            return e.jugadores.Contains(j);
            #endregion

            #region Con For
            //for (int i = 0; i < e.jugadores.Count; i++)
            //{
            //    if (Equals(e.jugadores[i], j))
            //    {
            //        return true;
            //    }
            //}

            //return false;
            #endregion

            #region Con Foreach
            //bool retorno = false;

            //foreach(Jugador jugador in e.jugadores)
            //{
            //    if ( ReferenceEquals(jugador, j) ) {
            //        return true;
            //    }
            //}

            //return retorno;
            #endregion

        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }



        #endregion


    }
}
