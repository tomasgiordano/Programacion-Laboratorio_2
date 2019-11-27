using System;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {
        private Planeta<Satelite> planeta;

        public FormSistemaSolar()
        {
            InitializeComponent();
            planeta = new Planeta<Satelite>(20, 20, "Jupiter");
        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {
            if(planeta.HiloRotacion!=null)
            {
                Thread hilo = new Thread(this.planeta.RunEvntRotar);
                hilo.Start();
            }

            if(this.planeta.AstrotEvent.GetInvocationList() == null)
            {
                //Agrego el metodo MostrarMensaje como manejador
                planeta.AstrotEvent += this.MostrarMensaje;
            }
        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {

        }

        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {
            try
            {
                bool seAgrego=false;
                int duracionOrbita=Convert.ToInt32(txOrbita.Text);
                int duracionRotacion=Convert.ToInt32(txRota.Text);
                            
                Satelite s = new Satelite(duracionOrbita,duracionRotacion,txNombre.Text);

                if(planeta+s)
                {
                    seAgrego= planeta+s;
                    SateliteDB.Guardar(s);
                }
                else
                {
                    throw new SateliteException();
                }
            }
            catch(SateliteException f)
            {
                MessageBox.Show(this,f.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception f)
            {
                MessageBox.Show(this, f.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
