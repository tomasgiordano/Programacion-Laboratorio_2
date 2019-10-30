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
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        List<Persona> lista = new List<Persona>();
        
        public List<Persona> Lista { get { return this.lista; } }

        public frmVisorPersona()
        {
            InitializeComponent();
            
        }

        public frmVisorPersona(List<Persona> list):this()
        {
            this.lista = list;
            ActualizarLista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if(frm.DialogResult==DialogResult.OK)
            {
                lista.Add(frm.Persona);
                ActualizarLista();
            }
            

            //implementar

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona(/*params*/);
            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            

            //implementar
        }

        public void ActualizarLista()
        {
            lstVisor.Items.Clear();

            foreach(Persona p in lista)
            {
                lstVisor.Items.Add(p.ToString());
            }
        }
    }
}
