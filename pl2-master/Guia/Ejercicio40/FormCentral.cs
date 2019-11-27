using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio40
{
    public partial class FormCentral : Form
    {

        private Centralita centralitaForm;

        public FormCentral(Centralita c) //Sería formMenú
        {
            InitializeComponent();
            this.centralitaForm = c;
        }

        private void FormCentral_Load(object sender, EventArgs e)
        {
            //this.buttonFacturacionLocal.Enabled = false;
            //this.buttonFacturacionProvincial.Enabled = false;
            //this.buttonFacturacionTotal.Enabled = false;
        }

        private void buttonGenerarLlamada_Click(object sender, EventArgs e)
        {
            //Si se presiona btnGenerarLlamada abrir un nuevo formulario como Dialog:

            FormLlamador fl = new FormLlamador(this.centralitaForm);

            if(fl.ShowDialog() == DialogResult.OK)
            {
                this.centralitaForm = fl.DevolverCentralita;
                this.buttonFacturacionLocal.Enabled = true;
                this.buttonFacturacionProvincial.Enabled = true;
                this.buttonFacturacionTotal.Enabled = true;
                
            }
        }

        private void buttonFacturacionTotal_Click(object sender, EventArgs e)
        {
            FormMostrar fMostrar = new FormMostrar(centralitaForm);
            fMostrar.MostrarFactura = Llamada.TipoLlamada.Todas;
            fMostrar.Show();
        }

        private void buttonFacturacionLocal_Click(object sender, EventArgs e)
        {
            FormMostrar fMostrar = new FormMostrar(centralitaForm);
            fMostrar.MostrarFactura = Llamada.TipoLlamada.Local;
            fMostrar.Show();
        }

        private void buttonFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FormMostrar fMostrar = new FormMostrar(centralitaForm);
            fMostrar.MostrarFactura = Llamada.TipoLlamada.Provincial;
            fMostrar.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
