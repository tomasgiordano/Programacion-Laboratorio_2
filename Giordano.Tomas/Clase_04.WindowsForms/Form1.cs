using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.Entidades;

namespace Clase_04.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cosa cosa = new Cosa(int.Parse(this.textBox1.Text),this.textBox3.Text,DateTime.Parse(this.textBox4.Text));
            MessageBox.Show(cosa.Mostrar());

            listBox1.Items.Add(cosa.Mostrar());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor =Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSlateGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
