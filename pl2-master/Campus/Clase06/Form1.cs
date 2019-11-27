using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06
{
    public partial class Form1 : Form
    {
        private bool flagBotones = false;

        public Form1()
        {
            InitializeComponent();
            txtResultado.Enabled = true;
            this.EnableButtons(false);
        }

        private void rtxtTexto_TextChanged(object sender, EventArgs e)
        {
            if (!flagBotones)
            {
                this.EnableButtons(true);
            }

            //this.lblCantPalabras.Text = this.CantidadPalabras(this.rtxtTexto.Text).ToString();
            this.lblCantPalabras.Text = this.rtxtTexto.Text.Replace(" ", string.Empty).Length.ToString();
            this.lblCantFinalizaA.Text = this.DevolverCantA(this.rtxtTexto.Text).ToString();  
        }

        #region MÉTODOS

        /// <summary>
        /// Funcion para acortar código, desactiva o activa botones, esto debería hacerse de otra manera
        /// </summary>
        /// <param name="estado"></param>
        private void EnableButtons(bool estado)
        {
            button3primerasO.Enabled = estado;
            button3primerasA.Enabled = estado;
            button100letras.Enabled = estado;
            button20palabras.Enabled = estado;
        }

        /// <summary>
        /// Recibe un string, lo recorta en espacios, y retorna la cantidad de palabras.
        /// PROBLEMA: Cada espacio lo va contar como palabra también.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>Cantidad de palabras</returns>
        private int CantidadPalabras(string pTexto)
        {
            return pTexto.Replace(" ", string.Empty).Length;
        }

        /// <summary>
        /// Cantidad de palabras finalizadas con subcadena “a ” (letra A seguida por un espacio) (muestra en lblCantAEspacio).
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        private int DevolverCantA(string txt)
        {
            int cant = 0;

            for(int i = 0; i < txt.Length; i++)
            {
                if(i+1 < txt.Length) //Para que no salga de la dimensión del Array
                {
                    if(txt[i] == 'a' && txt[i+1] == ' ')
                    {
                        cant++;
                    }
                    else if (txt[i] == 'A' && txt[i + 1] == ' ')
                    {
                        cant++;
                    }
                }
            }

            return cant;
        }

        private string buscarPalabraFinalizadaEn(string contiene, short cantidad)
        {
            string text = this.rtxtTexto.Text;

            //text.ind

            return null;
        }

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3primerasO_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = this.buscarPalabraFinalizadaEn("o", 3);
        }

        private void button3primerasA_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = this.buscarPalabraFinalizadaEn("a", 3);
        }

        private void button20palabras_Click(object sender, EventArgs e)
        {

            if(int.Parse(this.lblCantPalabras.Text) >= 20)
            {
                this.txtResultado.Text = "";

                //Creo un array de string separando las palabras por espacios
                string[] listaDePalabras = this.rtxtTexto.Text.Split(' ');
                
                //Recorro el array de palabras, y las palabras que sean sólo de espacios, las borro
                for (int i = 0; i < listaDePalabras.Length; i++)
                {
                    if (listaDePalabras[i] == " ")
                    {
                        listaDePalabras[i] = string.Empty;
                    }
                }

                //Copio los elemtos de la lista de palabas en el text resultado
                int cont = 0;
                for(int i = 0; i < listaDePalabras.Length; i++)
                {
                    if(listaDePalabras[i] != string.Empty && cont <= 20)
                    {
                        this.txtResultado.Text += listaDePalabras[i];
                        cont++;
                    }
                }
            }
        }

        /// <summary>
        /// Las primeras 100 letras (muestra en txtResultado)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button100letras_Click(object sender, EventArgs e)
        {
            string auxS = this.rtxtTexto.Text.Replace(" ", string.Empty);

            if (auxS.Length >= 100)
            {
                this.txtResultado.Text = "";

                for(int i = 0; i <= 100; i++)
                {
                    this.txtResultado.Text += auxS[i];
                }

            }
        }


    }
}

