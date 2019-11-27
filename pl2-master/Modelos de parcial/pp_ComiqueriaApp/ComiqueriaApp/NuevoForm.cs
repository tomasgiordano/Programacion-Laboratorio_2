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

namespace ComiqueriaApp
{
    /// <summary>
    /// No recibe nada, pero devuelve un Producto nuevo
    /// </summary>
    public partial class NuevoForm : Form
    {
        private Producto productoNuevo;


        public NuevoForm()
        {
            InitializeComponent();
        }

        public Producto DevolverProducto
        {
            get
            {
                return this.productoNuevo;
            }
        }

        private void NuevoForm_Load(object sender, EventArgs e)
        {
            this.comboBoxTipoProducto.Items.Add("Figura");
            this.comboBoxTipoProducto.Items.Add("Comic");
            this.comboBoxTipoProducto.SelectedItem = "Comic";

            this.comboBoxTipoDeComic.DataSource = Enum.GetValues(typeof(Comic.TipoComic));

            this.groupBoxComic.Enabled = false;
            this.groupBoxFigura.Enabled = false;
        }

        private void comboBoxTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.comboBoxTipoProducto.SelectedItem == "Comic")
            {
                this.groupBoxComic.Enabled = true;
                this.groupBoxFigura.Enabled = false;
            }
            else
            {
                this.groupBoxComic.Enabled = false;
                this.groupBoxFigura.Enabled = true;
            }
            
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(this.comboBoxTipoProducto.SelectedItem == "Comic")
            {
                Comic.TipoComic tipoComic;
                Enum.TryParse<Comic.TipoComic>(this.comboBoxTipoDeComic.SelectedValue.ToString(), out tipoComic);

                Producto p = new Comic(
                    this.richTextBoxDescripcion.Text, 
                    (int)this.numericUpDownStock.Value, 
                    int.Parse(this.textBoxPrecio.Text), 
                    this.textBoxAutor.Text,
                    tipoComic
                    );

                this.productoNuevo = p;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Producto p = new Figura(
                    this.richTextBoxDescripcion.Text,
                    (int)this.numericUpDownStock.Value,
                    int.Parse(this.textBoxPrecio.Text),
                    double.Parse(this.textBoxAltura.Text)
                    );

                this.productoNuevo = p;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
