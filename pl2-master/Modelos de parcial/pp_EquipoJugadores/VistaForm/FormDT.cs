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

namespace VistaForm
{
    public partial class FormDT : Form
    {
        private DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            int edad = (int)this.numericUpDownEdad.Value;
            int dni = (int)this.numericUpDownDni.Value;
            int experiencia = (int)this.numericUpDownExperiencia.Value;
            this.dt = new DirectorTecnico(nombre,apellido,edad,dni,experiencia);

            string mostrar = dt.Mostrar();

            MessageBox.Show("DT creado:" + mostrar);
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (ReferenceEquals(this.dt, null))
            {
                MessageBox.Show("Aún no se creo un DT en el formulario");
            }else if (this.dt.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto");
            }
            else
            {
                MessageBox.Show("El DT no es apto");
            }
        }
    }
}
