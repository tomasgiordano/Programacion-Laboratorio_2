using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo.Entidades;

namespace CentralitaWindowsForms
{
    public partial class FrmCentralita : Form
    {
        Centralita central;

        public FrmCentralita()
        {
            InitializeComponent();
            central = new Centralita();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            FrmLocal local = new FrmLocal();
            local.ShowDialog();

            if(local.DialogResult==DialogResult.OK)
            {
                central.Llamadas.Add(local.GetLlamada);
                ActualizarLista();
            }
        }

        private void btnProvincial_Click(object sender, EventArgs e)
        {
            FrmProvincial provincial = new FrmProvincial();
            provincial.ShowDialog();

            if (provincial.DialogResult == DialogResult.OK)
            {
                central.Llamadas.Add(provincial.GetLlamada);
                ActualizarLista();
            }

        }

        private void ActualizarLista()
        {
            foreach(Llamada a in central.Llamadas)
            {
                lstVisor.Items.Clear();
                this.lstVisor.Items.Add(a);
            }
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(this.cboOrdenamiento.SelectedItem)
            {
                case "Ascendente":
                    central.OrdenarLLamadas(1);
                    break;
                case "Descendente":
                    central.OrdenarLLamadas(-1);
                    break;
            }
            ActualizarLista();
        }
    }
}
