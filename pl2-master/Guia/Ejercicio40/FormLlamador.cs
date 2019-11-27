using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio40
{
    public partial class FormLlamador : Form
    {
        private Centralita centralita;
        private bool flag = false;
        private bool flagNumeral = false;
        

        public FormLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita DevolverCentralita
        {
            get
            {
                return this.centralita;
            }
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            this.comboBoxFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            this.buttonLimpiar.Enabled = false;
        }

        private void textBoxNumeroDestino_TextChanged(object sender, EventArgs e)
        {
            //Si comienza con # es Provincial
            if(this.textBoxNumeroDestino.Text.Contains("#"))
            {
                this.comboBoxFranja.Enabled = true;
            }
            else
            {
                this.comboBoxFranja.Enabled = false;
            }

            this.buttonLlamar.Enabled = true;
            this.buttonLimpiar.Enabled = true;
        }

        #region Métodos rancios

        //Limpio y/o agrego el número
        private void cargarNumeroDestino(int n)
        {
            if(this.textBoxNumeroDestino.Text == "Número destino")
            {
                this.textBoxNumeroDestino.Text = "";
                this.buttonNumeral.Enabled = false;
            }

            this.textBoxNumeroDestino.Text += n;
        }

        private void cargarNumeroDestino(char c)
        {
            if (this.textBoxNumeroDestino.Text == "Número destino")
            {
                this.textBoxNumeroDestino.Text = "";
                this.buttonNumeral.Enabled = false;
            }

            this.textBoxNumeroDestino.Text += c;
        }

        #endregion

        //Debe haber otra forma más sencilla de hacer esto:
        #region Teclado númerico

        private void button1_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(1);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino(0);
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino('*');
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            this.cargarNumeroDestino('#');
            this.flagNumeral = true;
        }


        #endregion

        private void textBoxNumeroOrigen_Click(object sender, EventArgs e)
        {
            if (!flag) //Para que lo haga una vez
            {
                this.textBoxNumeroOrigen.Text = "";
                flag = true;
            }
            
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            this.textBoxNumeroDestino.Text = "Número destino";
            this.textBoxNumeroOrigen.Text = "Número origen";
            this.comboBoxFranja.Enabled = false;
            this.flag = false;
            this.buttonNumeral.Enabled = true;
            this.flagNumeral = false;
            this.buttonLimpiar.Enabled = false; 
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            //Sí está activo guardo la franja en 'franja'
            Random r = new Random();
            float duracion = r.Next(1, 50);
            float costo = r.Next(5, 56);
            costo = costo / 10;
            string destino = this.textBoxNumeroDestino.Text;
            string origen = this.textBoxNumeroOrigen.Text;
            
            //Es llamada provincial
            if (this.flagNumeral)
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(comboBoxFranja.SelectedValue.ToString(), out franja);

                Provincial llamadaP = new Provincial( origen, franja, duracion, destino);
                this.centralita.Llamadas.Add(llamadaP);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Local llamadaL = new Local(origen, duracion, destino, costo);
                this.centralita.Llamadas.Add(llamadaL);

                DialogResult = DialogResult.OK;
                this.Close();

            }

            this.Close();

        }
    }
}
