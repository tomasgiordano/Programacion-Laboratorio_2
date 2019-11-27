using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{

    delegate void CambiarHoraDelegado(DateTime t);

    public partial class Form1 : Form
    {

        Thread hilo;

        public Form1()
        {
            InitializeComponent();

            this.labelHora.Text = DateTime.Now.ToString();

            ThreadStart delegado = new ThreadStart(AsignarHora);
            this.hilo = new Thread(delegado);
            
            this.hilo.Start();
        }

        public void AsignarHora()
        {
            DateTime t = DateTime.Now;

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                this.CambiarHora(DateTime.Now);
            }

            MessageBox.Show("Terminó de medir la hora");

        }

        public void CambiarHora(DateTime t)
        {
            if (this.InvokeRequired)
            {
                CambiarHoraDelegado delegado = new CambiarHoraDelegado(CambiarHora);
                object[] parametros = new object[] { t };
                
                this.Invoke(delegado, t);
            }
            else
            {
                this.labelHora.Text = t.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
        }
    }
}
