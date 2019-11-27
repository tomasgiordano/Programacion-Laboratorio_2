using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Formulario
{
    public partial class FormCorredores : Form
    {
        #region Atributos

        private List<Persona> corredores;
        private List<Thread> corredoresActivos;
        private bool hayGanador;

        #endregion

        public FormCorredores()
        {
            InitializeComponent();
            this.Text = "Corredores";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            this.corredores = new List<Persona>();
            this.corredoresActivos = new List<Thread>();
            this.corredores.Add(new Persona("Fernando", 9, Corredor.ECarril.Carril_1));
            this.corredores.Add(new Persona("Fernando", 15, Corredor.ECarril.Carril_2));
            this.hayGanador = false;

        }

        #region Métodos

        /// <summary>
        /// LimpiarCarriles volverá los ProgressBar a valor 0.
        /// </summary>
        private void LimpiarCarriles()
        {
            this.pgbCarril1.Value = 0;
            this.pgbCarril2.Value = 0;
        }

        /// <summary>
        /// HayGanador detendrá los hilos, guardará al ganador y lo anunciará por pantalla por medio de un MessageBox. 
        /// </summary>
        /// <param name="corredor"></param>
        private void HayGanador(Corredor corredor)
        {
            if (hayGanador)
            {
                foreach(Thread h in this.corredoresActivos)
                {
                    h.Abort();
                }

                corredor.Guardar("ganadores.txt");

                MessageBox.Show(corredor.ToString(),"Hay ganador", MessageBoxButtons.OK);

                this.buttonCorrer.Enabled = true;

            }
        }

        /// <summary>
        /// AnalizarCarrera analiza al competidor, suma en el ProgressBar el avance y avisa si hay ganador. 
        /// </summary>
        /// <param name="carril"></param>
        /// <param name="avance"></param>
        /// <param name="corredor"></param>
        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {
            if(carril.Value+avance<100 && !this.hayGanador)
            {
                carril.Value += avance;
            }
            else if(!this.hayGanador)
            {
                carril.Value = 100;
                this.hayGanador = true;
                this.HayGanador(corredor);
                LimpiarCarriles();
            }
        }

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (pgbCarril1.InvokeRequired || pgbCarril2.InvokeRequired)
            {
                Persona.CorrenCallback d = new Persona.CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if(corredor.CarrilElegido == Corredor.ECarril.Carril_1)
                {
                    this.AnalizarCarrera(pgbCarril1, avance, corredor);
                }
                else
                {
                    this.AnalizarCarrera(pgbCarril2, avance, corredor);
                }
            }
        }

        #endregion

        private void buttonCorrer_Click(object sender, EventArgs e)
        {
            this.buttonCorrer.Enabled = false;
            this.hayGanador = false;
            this.corredoresActivos.Clear();

            Thread h1 = new Thread(this.corredores[0].Correr);
            Thread h2 = new Thread(this.corredores[1].Correr);

            this.corredoresActivos.Add(h1);
            this.corredoresActivos.Add(h2);

            try
            {
                corredoresActivos[0].Start();
                corredoresActivos[1].Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.corredores[0].Corriendo += this.PersonaCorriendo;
            this.corredores[1].Corriendo += this.PersonaCorriendo;

        }

        private void FormCorredores_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread h in this.corredoresActivos)
            {
                h.Abort();
            }
        }
    }
}
