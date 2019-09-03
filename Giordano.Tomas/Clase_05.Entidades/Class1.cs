using System;

namespace Clase_05.Entidades
{
    /// <summary>
    ///                                                     CLASE TINTA
    /// </summary>
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        /// <summary>
        /// 
        /// </summary>
        public Tinta()
        {
            this.color = ConsoleColor.Blue;
            this.tipo = ETipoTinta.Comun;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipo"></param>
        /// <param name="color"></param>
        public Tinta(ETipoTinta tipo, ConsoleColor color) : this(color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string Mostrar()
        {
            return this.color.ToString() + " " + this.tipo.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tinta"></param>
        /// <returns></returns>
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            if ((tinta1.color == tinta2.color) && (tinta1.tipo == tinta2.tipo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tinta1"></param>
        /// <param name="tinta2"></param>
        /// <returns></returns>
        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static bool operator ==(Tinta tinta, ConsoleColor color)
        {
            if (tinta.color == color)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta, ConsoleColor color)
        {
            return !(tinta == color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
    /// <summary>
    ///                                                             CLASE PLUMA
    /// </summary>
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 0;           
        }

        public Pluma(string marca):this()
        {
            this.marca = marca;
        }

        public Pluma(string marca,Tinta tinta):this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca,Tinta tinta,int cantidad):this(marca,tinta)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }

        private string Mostrar()
        {
            return this.marca.ToString() + " " + (string)this.tinta + " " + this.cantidad.ToString();
        }
        
        public static bool operator == (Pluma pluma, Tinta tinta)
        {
            return (pluma.tinta == tinta);
        }
        public static bool operator != (Pluma pluma, Tinta tinta)
        {
            return !(pluma==tinta);
        }

        public static Pluma operator + (Pluma pluma, Tinta tinta)
        {
            if(pluma==tinta&&pluma.cantidad<100)
            {
                pluma.cantidad++;
            }
            return pluma;
        }
    }    
}
