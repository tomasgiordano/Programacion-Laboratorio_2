using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06.Entidades;

namespace Clase_07
{
    public partial class MenuTempera : Form
    {
        public MenuTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.comboBox1.Items.Add(c);
            }
        }

        private void MenuTempera_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem=ConsoleColor.Magenta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(textBox2.Text)>100)
            {
                textBox2.Text = "100";
            }
            else if(Convert.ToInt64(textBox1.Text)<0)
            {
                textBox2.Text = "0";
            }

            Tempera t = new Tempera((ConsoleColor)this.comboBox1.SelectedItem,textBox1.Text,Convert.ToInt32(textBox2.Text));
            MessageBox.Show(t);
            this.Close();
        }
    }
}
