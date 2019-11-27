using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class FormPersona : Form
    {
        private Persona persona;
        public event DelegadoString EventoString;

        public FormPersona()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string cambio) {
            MessageBox.Show(cambio);
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.EventoString += this.NotificarCambio;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.persona == null){
                this.persona = new Persona(this.txtNombre.Text, this.txtApellido.Text);
                this.btnCrear.Text = "Actualizar";
                this.EventoString.Invoke("Persona creada: " + this.persona.Mostrar());
            }
            else {
                this.persona.Nombre = this.txtNombre.Text;
                this.persona.Apellido = this.txtApellido.Text;
                this.EventoString.Invoke("Persona actualizada: " + this.persona.Mostrar());
            }
        }


    }
}
