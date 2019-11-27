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
    public partial class FormEmpresa : Form
    {

        public Empresa empresa;

        public FormEmpresa()
        {
            InitializeComponent();
            this.Text = "Empresa";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        public FormEmpresa(Empresa e):this() {
            this.empresa = e;
            this.textBoxRazonSocial.Text = e.RazonSocial;
            this.textBoxDireccion.Text = e.Direccion;
            this.maskedTextBoxGanancias.Text = e.Ganancia.ToString();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            this.empresa = new Empresa(
                this.textBoxRazonSocial.Text, 
                this.textBoxDireccion.Text, 
                float.Parse(this.maskedTextBoxGanancias.Text)
                );

            FormEmpleado frmEmpleado = new FormEmpleado(this.empresa);
            frmEmpleado.Show();
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            if (this.empresa != null) { 
                this.textBoxRazonSocial.Text = this.empresa.RazonSocial;
                this.textBoxDireccion.Text = this.empresa.Direccion;
                this.maskedTextBoxGanancias.Text = this.empresa.Ganancia.ToString();
            }
            else{
                this.textBoxRazonSocial.Text = "";
                this.textBoxDireccion.Text = "";
                this.maskedTextBoxGanancias.Text = "0";
            }
        }
    }
}
