using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio22;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = "Ejercicio25";

            //Desactivo los botones para que no se puedan usar antes de introducir un número
            btnBinToDec.Enabled = false;
            btnDecToBin.Enabled = false;

            //Solo lectura a los textBox de resultados
            txtResultadoDec.ReadOnly = true;
            txtResultadoBin.ReadOnly = true;
        }


        #region Binario a decimal
        private void txtBinario_TextChanged(object sender, EventArgs e)
        {
            //Activo el botón cuando se comience a ingresar un número.
            btnBinToDec.Enabled = true;
        }

        private void txtBinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Controlo que sólo se ingresen números
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("No se permiten letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            //Controlo que sólo se ingresen números 1 y 0
            else if ( e.KeyChar != (char)Keys.D1 && e.KeyChar != (char)Keys.D0 && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números 1 (uno) y 0 (cero).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            //string binario = txtBinario.Text; //Sin usar la clase NumeroBinario

            //Creo el objeto con el valor recibido
            NumeroBinario nb = txtBinario.Text;
            //Casteo explicitamente para recibir el valor de ese objeto
            string binario = (string)nb;
            //Lo convierto, y lo muestro
            txtResultadoDec.Text = Conversor.BinarioDecimal(binario).ToString();
        }

        #endregion

        #region Decimal a binario
        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {
            //Activo el botón cuando se comience a ingresar un número.
            btnDecToBin.Enabled = true;
        }

        private void txtDecimal_KeyPress(object sender, KeyPressEventArgs e) {
            //Controlo que sólo se ingresen números
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            //double num = double.Parse(txtDecimal.Text); //Sin usar la clase NumeroDecimal.

            //Creo el objeto con el valor recibido
            NumeroDecimal nd = double.Parse(txtDecimal.Text);
            //Casteo explicitamente para recibir el valor de ese objeto
            double num = (double)nd;
            //Lo convierto, y lo muestro
            txtResultadoBin.Text = Conversor.DecimalBinario(num);
        }
        #endregion
    }
}
