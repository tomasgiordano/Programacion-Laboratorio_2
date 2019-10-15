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
            foreach (char a in Environment.GetFolderPath(Environment.SpecialFolder.System))
            {
                cmbUbicacion.Items.Add(a);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter(cmbUbicacion.SelectedItem.ToString() + txtTexto, false);
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
                StreamReader reader = new StreamReader(cmbUbicacion.SelectedItem.ToString() + txtTexto);
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
            foreach(var a in Environment.SpecialFolder)
            {
                cmbUbicacion.Items.Add(a);
            }
        }
    }
}
