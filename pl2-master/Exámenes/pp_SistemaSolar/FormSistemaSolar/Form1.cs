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

namespace FormSistemaSolar
{
    public partial class FormSS : Form
    {
        private static List<Astro> planetas;

        public FormSS()
        {
            InitializeComponent();
            FormSS.planetas = new List<Astro>();

            comboBoxTipoPlaneta.DataSource = Enum.GetNames(typeof(Tipo));

            for (int i = 0; i < planetas.Count; i++) {
                this.comboBoxPlaneta.Items.Add(planetas[i].ToString());
            }
        }

        private void buttonAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (this.txtTiempoCompletarOrbita.Text == "" || txtNombrePlaneta.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacios al agregar planetas.");
            }
            if (!validarPositivoCompletarOrbitaPlaneta())
            {
                MessageBox.Show("El tiempo en completar orbita debe ser positivo");
            }
            else {
                Planeta p = new Planeta(
                    (int)this.numCompletarRotacion.Value,
                    (int)this.numCompletarRotacion.Value,
                    this.txtNombrePlaneta.Text,
                    (int)this.numCantidadLunas.Value,
                    (Tipo)this.comboBoxTipoPlaneta.SelectedValue); //Que se vaya a dormir la conversion especifica

                FormSS.planetas.Add(p);
            }
        }

        private void buttonAgregarSatelite_Click(object sender, EventArgs e)
        {
            if (txtNombreSatelite.Text == "")
            {
                MessageBox.Show("No pueden haber campos vacios al agregar satelites.");
            }
            else if (this.numCompletarOrbitaSatelite.Value < 0 || this.numCompletarRotacionSatelite.Value < 0)
            {
                MessageBox.Show("No pueden haber campos vacios al agregar satelites.");
            }
            else {
                //Crear y agregar satelite
            }
        }

        /// <summary>
        /// Se debe validar que en el tiempo en completar órbita se introduzca un número positivo.
        /// </summary>
        /// <returns></returns>
        private bool validarPositivoCompletarOrbitaPlaneta() {
            int num = -1;
            if ( int.TryParse(this.txtTiempoCompletarOrbita.Text, out num) ) {
                if (num >= 1) {
                    return true;
                }
            }
            return false;
        }

        private void buttonMostrarInformacion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FormSS.planetas.Count; i++) {
                this.richTextBox1.Text += "\n" + FormSS.planetas[i].ToString();
            }
            
        }
    }
}
