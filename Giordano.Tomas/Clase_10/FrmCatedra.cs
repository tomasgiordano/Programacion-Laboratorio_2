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
    public partial class FrmCatedra : Form
    {
        private Catedra miCatedra;
        public List<AlumnoCalificado> misAlumnos;

        public FrmCatedra()
        {
            InitializeComponent();
            miCatedra = new Catedra();

            foreach (ETipoOrdenamiento ord in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenar.Items.Add(ord);
            }
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrdenar.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool seSumo = false;
            FrmAlumno formAlumno = new FrmAlumno();

            formAlumno.StartPosition = FormStartPosition.CenterScreen;
            formAlumno.FormBorderStyle = FormBorderStyle.FixedSingle;
            formAlumno.ShowDialog();

            if (formAlumno.DialogResult == DialogResult.OK)
            {
                seSumo = this.miCatedra + formAlumno.MiAlumno;
                this.ActualizarListadoAlumnos();
            }
        }

        private void ActualizarListadoAlumnos()
        {
            if (!Object.Equals(this.miCatedra, null))
            {
                this.lbxAlumnos.Items.Clear();

                switch ((ETipoOrdenamiento)this.cmbOrdenar.SelectedItem)
                {
                    case ETipoOrdenamiento.LegajoAscendente:
                        this.miCatedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                        break;
                    case ETipoOrdenamiento.LegajoDescendente:
                        this.miCatedra.GetAlumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                        break;
                    case ETipoOrdenamiento.ApellidoAscendente:
                        this.miCatedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                        break;
                    case ETipoOrdenamiento.ApellidoDescendente:
                        this.miCatedra.GetAlumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                        break;
                }

                foreach (Alumno a in miCatedra.GetAlumnos)
                {
                    this.lbxAlumnos.Items.Add(Alumno.Mostrar(a));
                }
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos();
        }
    }
}
