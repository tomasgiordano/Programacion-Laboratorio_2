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
    public partial class FrmAlumno : Form
    {
        Alumno miAlumno;

        public Alumno MiAlumno { get { return this.miAlumno; } }

        public FrmAlumno()
        {
            InitializeComponent();

            this.cmbTipoExamen.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (ETipoExamen e in Enum.GetValues(typeof(ETipoExamen)))
            {
                this.cmbTipoExamen.Items.Add(e);
            }

            this.cmbTipoExamen.SelectedItem = ETipoExamen.Tercero;
        }

        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                miAlumno = new Alumno(this.txtNombre.Text, this.txtApellido.Text, int.Parse(this.txtLegajo.Text), (ETipoExamen)this.cmbTipoExamen.SelectedItem);
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Faltan datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void Modificar(Alumno a)
        {
            this.txtLegajo.Enabled = false;
            this.txtNombre.Text = a.GetNombre;
            this.txtLegajo.Text = a.GetLegajo.ToString();
            this.txtApellido.Text = a.GetApellido;
            this.cmbTipoExamen.SelectedItem = a.GetExamen;
        }
    }
}
