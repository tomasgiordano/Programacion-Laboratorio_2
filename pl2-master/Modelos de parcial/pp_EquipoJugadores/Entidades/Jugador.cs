using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        #region Fields
        private Posicion posicion;
        private float altura;
        private float peso;
        #endregion

        #region Propiedades

        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        new public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        #endregion

        #region Constructor

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        #endregion

        #region Métodos

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}", base.Mostrar());
            sb.AppendFormat("\nPosición: {0}", this.Posicion);
            sb.AppendFormat("\nAltura: {0}", this.Altura.ToString());
            sb.AppendFormat("\nPeso: {0}", this.Peso.ToString());
            return sb.ToString();
        }


        /// <summary>
        ///  Un jugador será apto para ingresar a un equipo siempre que su edad no supere los
        /// 40 años y se encuentre en estado físico
        /// </summary>
        /// <returns></returns>
        public override bool ValidarAptitud()
        {
            return (this.Edad < 40 && this.ValidarEstadoFisico() == true);
        }

        /// <summary>
        /// deberá validar que el índice de masa corporal se encuentre en el rango de 18.5 y
        /// 25 inclusive.Para calcularlo, utilizar la siguiente fórmula:
        /// IMC = peso / altura^2
        /// </summary>
        /// <returns></returns>
        public bool ValidarEstadoFisico()
        {
            double imc = this.Peso / (Math.Pow(this.Altura, 2));
            Math.Round(imc);
            return (imc > 18.5 && imc <= 25);
        }

        #endregion

    }
}
