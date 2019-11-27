using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
    TUTORIAL: https://www.youtube.com/watch?v=64A-3UOh4qs
*/
namespace MenúContextual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ContextMenú";
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Math.PI.ToString();
        }
    }
}
