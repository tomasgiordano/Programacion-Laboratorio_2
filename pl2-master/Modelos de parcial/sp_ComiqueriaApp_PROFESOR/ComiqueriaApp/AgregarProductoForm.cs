using ComiqueriaDataAccess;
using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComiqueriaApp
{
    public partial class AgregarProductoForm : Form
    {
        public AgregarProductoForm()
        {
            InitializeComponent();
        }

        private void TxtPrecio_TextChanged(object sender, EventArgs e)
        {
            this.lblError.Text = String.Empty;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string nuevaDescripcion = this.txtDescripcion.Text;
                double nuevoPrecio = Convert.ToDouble(this.txtPrecio.Text);
                int nuevoStock = (int)this.txtStock.Value;

                ProductosDB.Insert(nuevaDescripcion, nuevoPrecio, nuevoStock);

                this.Close();
            }
        }

        private bool Validar()
        {
            if (String.IsNullOrWhiteSpace(this.txtDescripcion.Text))
            {
                this.lblError.Text = "Error. Debe ingresar una descripción.";
                return false;
            }

            double nuevoPrecio;
            if (!Double.TryParse(this.txtPrecio.Text, out nuevoPrecio))
            {
                this.lblError.Text = "Error. Debe ingresar un precio válido.";
                return false;
            }

            if (this.txtStock.Value < 0)
            {
                this.lblError.Text = "Error. El stock debe ser mayor o igual a 0.";
                return false;
            }

            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
