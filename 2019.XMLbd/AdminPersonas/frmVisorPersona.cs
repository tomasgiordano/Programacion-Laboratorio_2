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
using System.Data.SqlClient;
namespace AdminPersonas
{
    public partial class frmVisorPersona : Form
    {
        List<Persona> lista = new List<Persona>();
        System.Data.SqlClient.SqlConnection conexion;

        public List<Persona> Lista { get { return this.lista; } }
        public DataTable table;

        public frmVisorPersona()
        {
            conexion = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.Conexion);
            table = new DataTable();

            InitializeComponent();
            
        }

        public frmVisorPersona(List<Persona> list):this()
        {
            this.lista = list;
            ActualizarLista();
        }

        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.lista.Add(frm.Persona);
                ActualizarLista();

                try
                {
                    conexion.Open();
                    System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "Insert into Personas(nombre,apellido,edad) values('" + frm.Persona.nombre + "','" + frm.Persona.apellido + "'," + frm.Persona.edad + ')';
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception f)
                {
                    throw f;
                }

            }
        }
       protected virtual void btnModificar_Click(object sender, EventArgs e)
       {
            frmPersona frm = new frmPersona(this.lista[this.lstVisor.SelectedIndex]);
            int id;
            id = this.GetId(frm.Persona);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                this.lista[this.lstVisor.SelectedIndex] = frm.Persona;
                try
                {

                    conexion.Open();
                    System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "Update Personas set nombre='" + frm.Persona.nombre + "',apellido='" + frm.Persona.apellido + "',edad=" + frm.Persona.edad + "where id=" + id;
                    comando.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception f)
                {
                    throw f;
                }
                this.ActualizarLista();

                //implementar
            }
       }

        public virtual void ActualizarLista()
        {
            lstVisor.Items.Clear();

            foreach(Persona p in lista)
            {
                lstVisor.Items.Add(p.ToString());
            }
        }

        private int GetId(Persona p1)
        {
            this.conexion.Open();
            int id = -1;
            System.Data.SqlClient.SqlCommand comando = new System.Data.SqlClient.SqlCommand();
            comando.Connection = this.conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT TOP 1000 [id],[nombre],[apellido],[edad]FROM[personas_bd].[dbo].[personas]";
            System.Data.SqlClient.SqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read() != false)
            {
                if (reader["nombre"].ToString() == p1.nombre && reader["apellido"].ToString() == p1.apellido && Convert.ToInt16(reader["edad"]) == p1.edad)
                {

                    id = Convert.ToInt16(reader["id"]);
                }

            }
            reader.Close();
            this.conexion.Close();
            return id;

        }

        protected virtual void btnEliminar_Click(object sender, EventArgs e)
        {            
            if(lstVisor.SelectedIndex!=-1)
            {
                frmPersona frmP = new frmPersona(this.lista[this.lstVisor.SelectedIndex]);
                int id = GetId(frmP.Persona);
                try
                {
                    this.lista.Remove(frmP.Persona);
                    SqlCommand comando = new SqlCommand();
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = "delete from Personas where id ="+id;
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    this.ActualizarLista();
                }
                catch(Exception f)
                {
                    throw f;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una persona.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmVisorPersona_Load(object sender, EventArgs e)
        {
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
        }

        private void lstVisor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnModificar.Click += new EventHandler(this.btnModificar_Click);
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);
        }

    }
}
