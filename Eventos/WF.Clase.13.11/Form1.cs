using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clase._13._11;

namespace WF.Clase._13._11
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            foreach (TipoManejador valor in Enum.GetValues(typeof(TipoManejador)))
            {
                this.cmbManejador.Items.Add(valor);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

           Empleado e1 = new Empleado(txtNombre.Text, txtApellido.Text, Convert.ToInt16(txtLegajo.Text));
            switch (this.cmbManejador.SelectedItem)
            {
                case TipoManejador.LimiteSueldoMejorado:
                    e1.limiteMejorado += new LimiteSueldoMejoradoDel(this.ManejadorDeEventoMejorado2);
                    break;

                case TipoManejador.LimiteSueldo:
                    e1.limiteSueldo += new LimiteSueldoDelegado(this.ManejadorDeEvento);                    
                    break;

                case TipoManejador.Todos:
                    e1.limiteMejorado += new LimiteSueldoMejoradoDel(this.ManejadorDeEventoMejorado2);
                    e1.limiteSueldo += new LimiteSueldoDelegado(this.ManejadorDeEvento);
                    break;
            }
            e1.Sueldo = Convert.ToDouble(txtSueldo.Text);
        }      

        private void ManejadorDeEvento(double sueldo, Empleado e1)
        {
            MessageBox.Show("Se quiso asignar en sueldo el valor: " + sueldo);
            MessageBox.Show(e1.ToString());
        }

        private static void ManejadorDeEventoMejorado(Empleado e, EmpleadoEventArgs sender)
        {
            MessageBox.Show("No se puedo asignar el sueldo");
            MessageBox.Show(e.ToString());
        }

        private void ManejadorDeEventoMejorado2(Empleado e, EmpleadoEventArgs sender)
        {
            Form1.ManejadorDeEventoMejorado(e, sender);
        }
    }
}
