using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08
{
    public class Empresa
    {
        #region Atributos

        private List<Empleado> nominaEmpleados;
        private string razonSocial;
        private string direccion;
        private float ganancia;

        #endregion

        #region Propiedades

        public string RazonSocial
        {
            get { return this.razonSocial; }
            set { this.razonSocial = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public float Ganancia
        {
            get { return this.ganancia; }
            set { this.ganancia = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Codificar un constructor privado por defecto.
        /// Este será el único lugar donde se instanciará la nómina de empleados.
        /// </summary>
        private Empresa()
        {
            this.nominaEmpleados = new List<Empleado>();
        }

        /// <summary>
        /// Codificar otro constructor que reciba como parámetro la razón social, dirección y ganancias de la Empresa.
        /// </summary>
        /// <param name="razonSocial"></param>
        /// <param name="direccion"></param>
        /// <param name="ganancia"></param>
        public Empresa(string razonSocial, string direccion, float ganancia) : this()
        {
            this.RazonSocial = razonSocial;
            this.Direccion = direccion;
            this.Ganancia = ganancia;
        }


        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador + (Empresa, Empleado). Si el empleado no existe, lo agrega a la nómina.
        /// </summary>
        /// <param name="empresa"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static Empresa operator +(Empresa empresa, Empleado empleado)
        {

            for (int i = 0; i < empresa.nominaEmpleados.Count; i++)
            {
                if(empresa.nominaEmpleados[i] == empleado)
                {
                    return empresa;
                }
            }

            empresa.nominaEmpleados.Add(empleado);

            return empresa;

        }

        #endregion

        #region Métodos

        public string MostrarEmpresa()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("La empresa {0} sita en la calle {1} cuenta con ganancias por {2} y con {3} empleados:\n",
                this.RazonSocial, this.Direccion, this.Ganancia, this.nominaEmpleados.Count);

            for (int i = 0; i < this.nominaEmpleados.Count; i++)
            {
                sb.AppendFormat("{0}\n", this.nominaEmpleados[i].Mostrar());
            }

            return sb.ToString();
        }

        #endregion

    }
}
