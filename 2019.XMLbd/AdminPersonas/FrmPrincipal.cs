using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using Entidades;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {
        private List<Persona> lista;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            
            this.lista = new List<Persona>();

            
            
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            this.openFileDialog1.ShowDialog();
            XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
            StreamReader sr = new StreamReader(this.openFileDialog1.FileName);
            
            this.lista=(List<Persona>)ser.Deserialize(sr);
            
            sr.Close();
        }

        private void guardarEnArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //implementar...
            saveFileDialog1.ShowDialog();
            XmlSerializer ser = new XmlSerializer(typeof(List<Persona>));
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            ser.Serialize(sw,lista);

            sw.Close();
        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisorPersona frm = new frmVisorPersona(lista);

            frm.StartPosition = FormStartPosition.CenterScreen;

            //implementar
            this.lista = frm.Lista;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);
                connection.Open();
                MessageBox.Show("Exito");
                System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

                comando.Connection = connection;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";

                System.Data.SqlClient.SqlDataReader reader;
                reader=comando.ExecuteReader();
                while(reader.Read()!=false)
                {
                    MessageBox.Show(reader["id"].ToString());//En vez de id se puede pasar cualquier campo, O indice
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
