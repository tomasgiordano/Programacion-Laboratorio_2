using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeerYEscribir
{
    public partial class Archivos : Form
    {
        public Archivos()
        {
            InitializeComponent();

            foreach (Environment.SpecialFolder item in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                cmbUbicacion.Items.Add(item);
            }           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
          {
            try
            {
                StreamWriter writer = new StreamWriter(@"C:\Users\alumno\"+ cmbUbicacion.SelectedItem.ToString() +@"\"+ txtNombre.Text, false);
                writer.WriteLine(txtTexto.Text);
                writer.Close();
            }
            catch(Exception)
            {
                txtTexto.Text = "ERROR!";
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {       
            try
            {
                StreamReader reader = new StreamReader(@"C:\Users\alumno\" + cmbUbicacion.SelectedItem.ToString() + @"\" + txtNombre.Text);
                txtTexto.Text=reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {
                txtTexto.Text = "ERROR!";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = "";
            txtNombre.Text = "";
            cmbUbicacion.Text = "";
        }

        private void cmbUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
