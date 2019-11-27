using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase08
{
    public partial class FormEmpleado : Form
    {

        public Empresa empresa;
        public FormEmpresa formularioEmpresa;

        public FormEmpleado()
        {
            InitializeComponent();

            this.Text = "Clase 08";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            comboBoxPuesto.DataSource = Enum.GetValues(typeof(EPuestoJerarquico));
        }

        public FormEmpleado(Empresa empresa):this()
        {
            this.empresa = empresa;
        }

        /// <summary>
        /// Al pulsar sobre el botón btnLimpiarForm se deberá limpiar el contenido de todos los campos del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLimpiarForm_Click(object sender, EventArgs e)
        {
            this.textBoxApellido.Text = "";
            this.textBoxNombre.Text = "";
            this.maskedTextBoxSalario.Text = "";
            this.maskedTextBoxLegajo.Text = "";
        }

        /// <summary>
        /// Al presionar el botón btnAgregarItem se deberá generar una nueva instancia de la clase Empleado y agregarlo a la Empresa.
        /// Luego se deberá mostrar la nómina en el campo rtxtConsola.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAgregarItem_Click(object sender, EventArgs e)
        {
            Empleado em = new Empleado(
                this.textBoxNombre.Text,
                this.textBoxApellido.Text,
                this.maskedTextBoxLegajo.Text,
                (EPuestoJerarquico)this.comboBoxPuesto.SelectedValue,
                int.Parse(this.maskedTextBoxSalario.Text)
                );

            this.empresa += em;

            this.richTextBoxConsola.Text = empresa.MostrarEmpresa();


        }

        /// <summary>
        /// Al pulsar btnEmpresa se deberá abrir el formulario frmEmpresa y actualizar los datos de la empresa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            this.CargarEmpresa();
        }


        /// <summary>
        /// Abre el formulario empresa, para cargarle datos
        /// </summary>
        public void CargarEmpresa()
        {

            formularioEmpresa = new FormEmpresa();

            DialogResult resultado = formularioEmpresa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.empresa = formularioEmpresa.empresa;
                this.richTextBoxConsola.Text = empresa.MostrarEmpresa();
            }


        }
    }
}
