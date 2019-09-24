using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10.Entidades;

namespace Clase_10
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void catedraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmCatedra = new FrmCatedra();
            frmCatedra.MdiParent = this;
            frmCatedra.StartPosition = FormStartPosition.CenterScreen;
            frmCatedra.Show();
        }
    }
}
