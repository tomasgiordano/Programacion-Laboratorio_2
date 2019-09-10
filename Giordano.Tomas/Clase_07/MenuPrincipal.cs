using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_07
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmTempera = new MenuTempera();
            frmTempera.MdiParent = this;
            frmTempera.Show();
        }

        private void paletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            paletaToolStripMenuItem.Enabled= false;
;        }
    }
}
