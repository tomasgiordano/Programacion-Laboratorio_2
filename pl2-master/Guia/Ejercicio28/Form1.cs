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

namespace Ejercicio28
{
    public partial class Ejercicio28 : Form
    {
        Dictionary<string, int> dicPalabras = new Dictionary<string, int>();

        public Ejercicio28()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        private void rtxtText_TextChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Guardo todo el texto en una variable
            string auxPalabras = "";
            string palabras = rtxtText.Text;
            //Corto en donde hay espacios y lo guardo en un Array de string
            string[] separadas = palabras.Split(' ');

            for(int i = 0; i < separadas.Length; i++)
            {
                //Agrego cada palabra en el diccionario 'dicPalabras'
                try
                {
                    dicPalabras.Add(separadas[i], 1);
                }
                catch(ArgumentException) //Si ya existe va entrar acá
                {
                    //Debería buscar la palarba que ya existe, y sumarle 1
                    foreach (KeyValuePair<string, int> item in dicPalabras)
                    {
                        //Si encuentra la palabra le sumo 1 al valor
                        if (item.Key == separadas[i])
                        {
                            dicPalabras[separadas[i]] += 1;
                            break;
                        }
                    }
                }
            }

            //Muestro el diccionario como esta, sin ordenar
            auxPalabras = auxPalabras + "Lista sin ordernar:\n\n";
            foreach (KeyValuePair<string, int> item in dicPalabras)
            {
                auxPalabras = auxPalabras + "Palabra: " + item.Key + " Repetido: " + item.Value + "\n";
            }
            auxPalabras = auxPalabras + "\nLista ordenada:\n";

            //Ordeno el diccionario en un nuevo objeto usando LINQ (esto no lo debería saber todavía)
            var dicOrdenado = from dicElemento in dicPalabras orderby dicElemento.Value descending select dicElemento;

            //Creo un string auxiliar para guardar el top de palabras mas repetidas
            string auxTop3 = "";
            int k = 0;
            foreach(object elemento in dicOrdenado)
            {
                auxPalabras = auxPalabras + elemento + "\n";
                if (k < 3) //Guardo las tres primeras que son las más repetidas
                {
                    auxTop3 = auxTop3 + elemento + "\n";
                }
                k++;
            }

            //Muestro todo en el richTextBox
            rtxtText.Text = auxPalabras;

            //Muestro las top tres en un Box
            MessageBox.Show("Top 3 palabras más repetidas: " + auxTop3);


            //dicPalabras.OrderBy();
            //https://www.iteramos.com/pregunta/1556/como-ordenar-un-diccionario-por-valor

            btnCalcular.Enabled = false;
        }//end btnCalcular_click


    }
}
