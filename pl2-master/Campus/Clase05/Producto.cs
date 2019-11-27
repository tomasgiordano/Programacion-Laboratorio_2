using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05
{
    class Producto
    {
        #region Atributos

        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        #endregion Atributos

        #region Constructores
        public Producto(string marca, string codigo, float precio)
        {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }
        #endregion Constructores

        #region Métodos
        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra.ToString();
        }

        public string GetMarca()
        {
            return this._marca;
        }

        public float GetPrecio()
        {
            return this._precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return p._codigoDeBarra.ToString() + " " + p._marca.ToString() + " " + p._precio.ToString();
        }

        #endregion

        #region Sobrecargas operadores

        public static bool operator ==(Producto p1, Producto p2)
        {
            if(Object.ReferenceEquals(p1,null) || Object.ReferenceEquals(p2, null))
            {
                return false;
            }

            return (p1._marca == p2._marca) && (p1._codigoDeBarra == p2._codigoDeBarra);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p._marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        #endregion Sobrecargas operadores


    }
}