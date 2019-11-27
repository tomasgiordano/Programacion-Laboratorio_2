using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controles;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;

        public FrmAerolinea()
        {
            InitializeComponent();

            this.aeropuerto = new Aeropuerto<Vuelo>();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;

            this.Controls.Add(vuelo);
            vuelo.Location = new Point(0, ejeY);
            
            vuelo.Despegar();
        }

        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aeropuerto.FinalizarVuelos();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este método");
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este método");
        }
    }
}
