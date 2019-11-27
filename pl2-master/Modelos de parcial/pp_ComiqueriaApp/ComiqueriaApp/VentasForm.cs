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

/*
  Va a necesitar acceso a la instancia de la comiqueria y al producto seleccionado en el principalForm.  
*/

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria comiqueria;
        private double precioFinal;

        public VentasForm(Comiqueria c, Producto p)
        {
            InitializeComponent();
            this.productoSeleccionado = p;
            this.comiqueria = c;
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = productoSeleccionado.Descripcion;
            this.lblPrecioFinal.Text = "Precio final: $" + productoSeleccionado.Precio.ToString();
            
            //El valor maximo del numericdown tiene que ser el stock del producto:
            //Esto no lo pide, así que lo saco.
            //this.numericUpDownCantidad.Maximum = productoSeleccionado.Stock;
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            this.precioFinal = this.productoSeleccionado.Precio * (double)this.numericUpDownCantidad.Value;
            this.lblPrecioFinal.Text = "Precio final: $" + this.precioFinal;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if(this.numericUpDownCantidad.Value <= this.productoSeleccionado.Stock)
            {
                //Se puede vender
                this.comiqueria.Vender(this.productoSeleccionado, (int)this.numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //No se puede vender
                MessageBox.Show("La cantidad selecionada supera al stock", "Insuficiente stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
