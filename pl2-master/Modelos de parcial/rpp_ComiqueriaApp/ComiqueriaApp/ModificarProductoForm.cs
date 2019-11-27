using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
using ComprobanteLogic;

namespace ComiqueriaApp
{
    public partial class ModificarProductoForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;

        public ModificarProductoForm(Comiqueria c, Producto p)
        {
            InitializeComponent();
            this.productoSeleccionado = p;
            this.comiqueria = c;
        }

        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {
            this.labelDescripcion.Text = productoSeleccionado.Descripcion;
            this.textBoxPrecioActual.Text = "$" + Math.Round(productoSeleccionado.Precio,2).ToString(); //Falta formatear decimales
            this.labelError.Text = "";

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            double precio;

            if(Double.TryParse(this.textBoxNuevoPrecio.Text, out precio))
            {
                DialogResult res = MessageBox.Show("Desea realizar esta modificacion?", "Confirmar modificacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(res == DialogResult.OK)
                {
                    this.productoSeleccionado.Precio = precio;
                    this.Close();
                }
            }
            else
            {
                this.labelError.Text = "Error. Debe ingresar un precio válido.";
            }
            
        }

        private void textBoxNuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            this.labelError.Text = "";
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
