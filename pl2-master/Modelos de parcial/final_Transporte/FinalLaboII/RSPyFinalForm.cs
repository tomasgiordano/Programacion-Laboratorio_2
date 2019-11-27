using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using EntidadesSPyFinal;

namespace FinalLaboII
{
    public partial class RSPyFinalForm : Form
    {
        public List<Transporte> listaTransportes;
        private List<Thread> hilos;

        public RSPyFinalForm()
        {
            InitializeComponent();
            this.listaTransportes = new List<Transporte>();
            this.hilos = new List<Thread>();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnViajar_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrarTrenes_Click(object sender, EventArgs e)
        {

        }

        private void ComenzarViaje(Transporte transporte)
        {
            MessageBox.Show(transporte.Transportar(transporte),"Comenzar viaje");
        }

        private void BtnMostrarAvion_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregarTren_Click(object sender, EventArgs e)
        {

        }
    }
}
