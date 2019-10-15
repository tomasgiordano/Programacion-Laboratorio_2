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
        public List<Alumno> misAlumnos;
        public List<AlumnoCalificado> misAlumnosCalificados;

        public FrmCatedra()
        {
            InitializeComponent();
            miCatedra = new Catedra();
            misAlumnosCalificados = new List<AlumnoCalificado>();
            foreach (ETipoOrdenamiento ord in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbOrdenar.Items.Add(ord);
            }
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOrdenar.SelectedItem = ETipoOrdenamiento.LegajoAscendente;
        }

        private void ActualizarListadoAlumnos()
        {
            if (!object.Equals(this.miCatedra, null))
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
                    this.lbxAlumnos.Items.Add(a.ToString());
                }
                //this.lbxAlumnos.Items.Add(miCatedra.ToString());
            }
        }

        private void ActualizarListadoAlumnosCalificados()
        {
            if (!object.Equals(this.miCatedra, null))
            {
                this.lbxAlumnosCalificados.Items.Clear();
                
                foreach (AlumnoCalificado a in misAlumnosCalificados)
                {
                    this.lbxAlumnosCalificados.Items.Add(a.Mostrar());
                }
                //this.lbxAlumnos.Items.Add(miCatedra.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool seSumo = false;

            FrmAlumno formAlumno = new FrmAlumno();
            formAlumno.ShowDialog();

            formAlumno.StartPosition = FormStartPosition.CenterScreen;
            formAlumno.FormBorderStyle = FormBorderStyle.FixedSingle;


            if (formAlumno.DialogResult == DialogResult.OK)
            {
                seSumo = this.miCatedra + formAlumno.MiAlumno;
                this.ActualizarListadoAlumnos();
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarListadoAlumnos();
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            FrmAlumnoCalificado frmCalificado = new FrmAlumnoCalificado();

            if(this.lbxAlumnos.SelectedIndex!=-1)
            {
                frmCalificado.Calificar(miCatedra.GetAlumnos[this.lbxAlumnos.SelectedIndex]);

                frmCalificado.StartPosition = FormStartPosition.CenterScreen;
                frmCalificado.FormBorderStyle = FormBorderStyle.FixedSingle;
                frmCalificado.ShowDialog();

                if (frmCalificado.DialogResult == DialogResult.OK)
                {
                    miCatedra.GetAlumnos[this.lbxAlumnos.SelectedIndex] = frmCalificado.AlumnoNota;
                    misAlumnosCalificados.Add(frmCalificado.AlumnoNota);
                    ActualizarListadoAlumnosCalificados();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumno = new FrmAlumno();
            if(this.lbxAlumnos.SelectedIndex!=-1)
            {
                frmAlumno.Modificar(miCatedra.GetAlumnos[this.lbxAlumnos.SelectedIndex]);

                frmAlumno.StartPosition = FormStartPosition.CenterScreen;
                frmAlumno.FormBorderStyle = FormBorderStyle.FixedSingle;

                frmAlumno.ShowDialog();

                if (frmAlumno.DialogResult == DialogResult.OK)
                {
                    miCatedra.GetAlumnos[this.lbxAlumnos.SelectedIndex] = frmAlumno.MiAlumno;
                    ActualizarListadoAlumnos();
                }
            }
            
        }
    }
}
