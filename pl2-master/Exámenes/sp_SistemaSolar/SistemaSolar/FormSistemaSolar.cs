using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Entidades;

namespace SistemaSolar
{
    public partial class FormSistemaSolar : Form
    {

        private Planeta<Satelite> planeta;

        public FormSistemaSolar()
        {
            InitializeComponent();
            this.planeta = new Planeta<Satelite>(20,20,"Jupiter");
            this.traerPlanetasDB();
        }

        private void traerPlanetasDB() {
            List<Satelite> listSat = new List<Satelite>();

            SateliteDB sql = new SateliteDB();

            try
            {
                listSat = sql.Leer();
            }
            catch (Exception e) {
                MessageBox.Show("Hubo un inconveniente al leer los Satelites de la base de datos");
            }

            foreach (Satelite sat in listSat) {
                this.planeta.Satelites.Add(sat);
            }

        }

        private void btnRotarPlaneta_Click(object sender, EventArgs e)
        {

        }

        private void btnOrbitarSatelite_Click(object sender, EventArgs e)
        {

        }

        private void btnSatelite_Click(object sender, EventArgs e)
        {

            Satelite satellite = new Satelite(
                    int.Parse(this.txOrbita.Text),
                    int.Parse(this.txRota.Text),
                    this.txNombre.Text
                );

            this.planeta.Satelites.Add(satellite);

            SateliteDB sql = new SateliteDB();

            try
            {
                sql.Guardar(satellite);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
