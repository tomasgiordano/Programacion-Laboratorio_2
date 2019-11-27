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

/*
    http://eledwin.com/blog/tutorial-de-hilos-en-c-con-ejemplos-parte-1-31
    http://eledwin.com/blog/tutorial-de-hilos-en-c-con-ejemplos-parte-2-35
    http://eledwin.com/blog/delegados-en-c-que-son-y-como-usarlos-30
*/

namespace Hilos
{

    delegate void CambiarProgresoDelegado(string texto, int valor);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIniciarProceso_Click(object sender, EventArgs e)
        {
            ThreadStart delegado = new ThreadStart(CorrerProceso);
            Thread hilo = new Thread(delegado);
            hilo.Start();

        }

        private void buttonMostrarMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mostrando un mensaje");
        }

        private void CorrerProceso()
        {

            this.CambiarProgreso("Iniciando progreso...", 0);

            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(500);
                this.CambiarProgreso(string.Format("Posicion {0}...", i), i);

            }

            this.CambiarProgreso("Completado!", 100);
            MessageBox.Show("Proceso finalizado!");

            /*
            Thread.Sleep(10000);
            MessageBox.Show("Proceso terminado!");*/
        }

        private void CambiarProgreso(string texto, int valor)
        {
            /* //Hacerlo así tirarí error:
            this.labelProgreso.Text = texto;
            this.progressBarProgreso.Value = valor;
            */

            if (this.InvokeRequired)//Preguntamos si la llamada se hace desde un hilo
            {
                //Sí es así, volvemos a llamar a CambiarProgreso pero esta vez, a través del delegado
                //Se instancia el delegado indicando el método a ejecutar:
                CambiarProgresoDelegado delegado = new CambiarProgresoDelegado(CambiarProgreso);

                //Ya que el delegado va invocar CambiarProgreso debemos indicarle los paramétros:
                object[] parametros = new object[] { texto, valor };

                //Invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros
                this.Invoke(delegado, parametros);
            }
            else
            {
                //Caso contrario se realiza la llamada a los controladores
                this.labelProgreso.Text = texto;
                this.progressBarProgreso.Value = valor;
            }
        }
    }
}
