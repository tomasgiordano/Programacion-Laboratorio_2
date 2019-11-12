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
using System.Data.SqlClient;

namespace AdminPersonas
{
    public partial class FrmPrincipal : Form
    {

        private List<Persona> lista;
        public System.Data.SqlClient.SqlConnection connection; 
        private DataTable tablaPersonas;
        private SqlDataAdapter adaptador;
        private SqlDataReader miLector;
        private SqlCommand comando;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            
            this.lista = new List<Persona>();
            this.connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);
            this.tablaPersonas = new DataTable("Personas");

            this.comando = new SqlCommand();
            this.comando.Connection = this.connection;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "select * from personas";

            //this.CargarDataTable();

            this.adaptador = new SqlDataAdapter(this.comando.CommandText, this.connection); // No hace falta hacer this.conexion.Open();

            // Configurando adaptador
            this.adaptador.Fill(this.tablaPersonas); //Carga lo que esta en memoria

            this.adaptador.InsertCommand = new SqlCommand("insert into personas values(@p1, @p2, @p3)", this.connection);
            this.adaptador.UpdateCommand = new SqlCommand("update personas set nombre = @p1, apellido = @p2, edad = @p3 where id = @p4", this.connection);
            this.adaptador.DeleteCommand = new SqlCommand("delete from personas where id = @p1", this.connection);

            // Configurando parametros de cada comando
            this.adaptador.InsertCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.adaptador.InsertCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.adaptador.InsertCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");

            this.adaptador.UpdateCommand.Parameters.Add("@p1", SqlDbType.VarChar, 50, "nombre");
            this.adaptador.UpdateCommand.Parameters.Add("@p2", SqlDbType.VarChar, 50, "apellido");
            this.adaptador.UpdateCommand.Parameters.Add("@p3", SqlDbType.Int, 10, "edad");
            this.adaptador.UpdateCommand.Parameters.Add("@p4", SqlDbType.Int, 10, "id");

            this.adaptador.DeleteCommand.Parameters.Add("@p1", SqlDbType.Int, 10, "id");
        }

        private void CargarDataTable()
        {
            this.connection.Open();

            this.comando.Connection = this.connection;
            this.comando.CommandType = CommandType.Text;
            this.comando.CommandText = "select * from personas";

            this.miLector = this.comando.ExecuteReader();

            this.tablaPersonas.Load(miLector);

            this.connection.Close();
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
                connection.Open();
                MessageBox.Show("Exito");
                
                connection.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void traerTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();

            comando.Connection = connection;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";

            System.Data.SqlClient.SqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read() != false)
            {
                this.lista.Add(new Persona(reader["nombre"].ToString(), reader["apellido"].ToString(), Convert.ToInt32(reader["edad"])));
            }
            connection.Close();
            reader.Close();
        }

        private void dataTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisorDataTable frmMiDataTable = new FrmVisorDataTable(this.tablaPersonas);
            frmMiDataTable.StartPosition = FormStartPosition.CenterScreen;
            frmMiDataTable.ShowDialog();

            this.tablaPersonas = frmMiDataTable.Tabla;
        }
    }
}
