using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio41
{
    public partial class FormMostrar : Form
    {
        private Llamada.TipoLlamada tipo;
        private Centralita centralita;

        public FormMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Llamada.TipoLlamada MostrarFactura
        {
            set
            {
                this.tipo = value;
            }
        }

        private void FormMostrar_Load(object sender, EventArgs e)
        {
            //this.richTextBoxMostrar.Text = centralita.ToString();

            if(this.tipo is Llamada.TipoLlamada.Local)
            {
                this.richTextBoxMostrar.Text += "LLAMADAS LOCALES:";
            }
            else if(this.tipo is Llamada.TipoLlamada.Provincial)
            {
                this.richTextBoxMostrar.Text += "LLAMADAS PROVINCIALES:";
            }
            else
            {
                this.richTextBoxMostrar.Text += "TODAS LAS LLAMADAS:";
            }

            //Comprobar de que tipo son las llamadas, y mostrar la lista:
            foreach(Llamada llamada in this.centralita.Llamadas)
            {
                switch (this.tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if(llamada is Local) {
                            this.richTextBoxMostrar.Text += llamada.ToString();
                        }
                        break;

                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            this.richTextBoxMostrar.Text += llamada.ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            this.richTextBoxMostrar.Text += llamada.ToString();
                        }
                        if (llamada is Provincial)
                        {
                            this.richTextBoxMostrar.Text += llamada.ToString();
                        }
                        break;
                }//End Switch
            }//End foreach

            if (this.tipo is Llamada.TipoLlamada.Local)
            {
                this.richTextBoxMostrar.Text += "\n\nGANANCIAS POR LOCAL: " + this.centralita.GananciasPorLocal;
            }
            else if (this.tipo is Llamada.TipoLlamada.Provincial)
            {
                this.richTextBoxMostrar.Text += "\n\nGANANCIAS POR PROVINCIAL: " + this.centralita.GananciasPorProvincial;
            }
            else
            {
                this.richTextBoxMostrar.Text += "\n\nGANANCIAS TOTAL " + this.centralita.GananciasPorTotal;
            }

        }//End MostrarLoad

    }
}
