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
    public partial class FrmVisorDataTable : frmVisorPersona
    {
        private DataTable tabla;

        public DataTable Tabla
        {
            get
            {
                return this.tabla;
            }
        }

        public FrmVisorDataTable(DataTable unaTabla) : base()
        {
            InitializeComponent();
            this.tabla = unaTabla;
            this.ActualizarLista();
        }

        public override void ActualizarLista()
        {
            this.lstVisor.Items.Clear();

            foreach (DataRow fila in this.tabla.Rows)
            {
                if (fila.RowState != DataRowState.Deleted)
                {
                    this.lstVisor.Items.Add(fila[1] + " - " + fila[2] + " - " + fila[3]);
                }
            }
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                DataRow fila = this.Tabla.NewRow();

                fila[1] = frm.Persona.nombre;
                fila[2] = frm.Persona.apellido;
                fila[3] = frm.Persona.edad;

                this.Tabla.Rows.Add(fila);
                this.ActualizarLista();
            }
        }

        protected override void btnModificar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;

            if (index != -1)
            {
                DataRow fila = this.Tabla.Rows[index];

                frmPersona frm = new frmPersona(new Persona(fila[1].ToString(), fila[2].ToString(), Convert.ToInt32(fila[3])));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();

                if (frm.DialogResult == DialogResult.OK)
                {
                    fila[1] = frm.Persona.nombre;
                    fila[2] = frm.Persona.apellido;
                    fila[3] = frm.Persona.edad;

                    this.ActualizarLista();
                }
            }
        }

        protected override void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = this.lstVisor.SelectedIndex;

            if (index != -1)
            {
                DataRow fila = this.Tabla.Rows[index];
                fila.Delete();
                this.ActualizarLista();
            }
        }

    }
}