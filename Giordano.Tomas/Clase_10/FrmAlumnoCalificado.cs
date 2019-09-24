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
    

    public partial class FrmAlumnoCalificado : FrmAlumno
    {
        private AlumnoCalificado alumnoNota;

        public FrmAlumnoCalificado()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                alumnoNota = new AlumnoCalificado(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem, double.Parse(this.txtNota.Text));
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Faltan datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
