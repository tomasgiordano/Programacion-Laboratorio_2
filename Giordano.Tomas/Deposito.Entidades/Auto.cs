using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deposito.Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color { get {return this._color; } }
        public string Marca { get {return this._marca; } }

        public Auto(string marca, string color)
        {
            this._color = color;
            this._marca = marca;
        }


        public static bool operator ==(Auto a, Auto b)
        {
            
                if (a.Color == b.Color && a.Marca == b.Marca)
                {
                    return true;
                }
            
            return false;
        }

        public static bool operator !=(Auto a,Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if(this is Auto)
            {
                if (this == (Auto)obj)
                {
                    return true;
                }
            }
            return false;

            return false;
        }

        public override string ToString()
        {
            return this.Marca + " - " + this.Color;
        }



    }
}
