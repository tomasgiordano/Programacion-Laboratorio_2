using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Avion
    {
        private int horasVuelo;
        private Thread vuelo;

        public enum EstadoVuelo { Programado, Volando, Aterrizado }

        #region Evento

        public delegate void ReportarEstado(int horaTotal, int horasRestante);
        public static event ReportarEstado ReporteDeEstado;

        #endregion

        #region Propiedades
        public EstadoVuelo Estado
        {
            get
            {
                if (!vuelo.IsAlive)
                {
                    return EstadoVuelo.Programado;
                }
                else if (vuelo.IsAlive)
                {
                    return EstadoVuelo.Volando;
                }
                else
                {
                    return EstadoVuelo.Aterrizado;
                }
            }
        }


        public int HorasDeVuelo
        {
            get
            {
                return this.horasVuelo;
            }
        }

        #endregion

        #region Constructor

        public Avion(int horasVuelo) {
            this.horasVuelo = horasVuelo;
        }

        #endregion

        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {
                Thread.Sleep(1000);
                horasRestantes = horasRestantes - 1;


                ReporteDeEstado(this.horasVuelo, horasRestantes);

            }
        }

        public void Estrellar()
        {
            if (vuelo.IsAlive)
            {
                vuelo.Abort();
            }
        }

        public void Despegar()
        {
            this.vuelo = new Thread(this.Volar);
        }

    }
}
