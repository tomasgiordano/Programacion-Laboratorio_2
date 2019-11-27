using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Formulario : Form
    {

        List<Persona> pList = new List<Persona>();
        private int ultimoIdSeleccionado;

        public Formulario()
        {
            InitializeComponent();
            //Persona p = new Persona("Julián", "Fernandez");
            //PersonaDAO.GuardarPersona(p);
            //Persona s = PersonaDAO.LeerPorID(1);
            //MessageBox.Show(s.Mostrar());

            pList = PersonaDAO.LeerPersonas();

        }

        /// <summary>
        /// ListBox mostrará la lista de Personas devuelta por el método Leer de Persona,
        /// invocado al presionar el botón btnLeer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLeer_Click(object sender, EventArgs e)
        {
            foreach(Persona p in pList)
            {
                this.listBoxPersonas.Items.Add(p.ToString());
            }

        }
        /// <summary>
        /// btnModificar actualizará la información de la Persona que se seleccionó con doble
        /// click en el ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            Persona p = PersonaDAO.LeerPorID(1);
            p.nombre = this.textBoxNombre.Text;
            p.apellido = this.textBoxApellido.Text;
        }

        /// <summary>
        /// Al hacer doble click sobre una persona, esta se deberá cargar en los TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxPersonas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Persona auxP = null;
            string personaSeleccionada = this.listBoxPersonas.SelectedItem.ToString();

            //Busco la persona que le hice doble click en la lista
            foreach(Persona p in pList)
            {
                if(personaSeleccionada == p.ToString())
                {
                    auxP = p;
                    break;
                }
            }

            if(auxP != null)
            {
                this.textBoxNombre.Text = auxP.nombre;
                this.textBoxApellido.Text = auxP.apellido;
                this.ultimoIdSeleccionado = auxP.id;
            }
        }



    }
}
