using System;

namespace Clase_06.Entidades
{
    public class Tempera    
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color,string marca,int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return (this.color.ToString() + " " + this.marca.ToString() + " " + this.cantidad.ToString()); 
        }

        public static implicit operator string(Tempera tempera)
        {
            string mensaje = "ObjNull";
            if(!Object.Equals(tempera,null))
            {
                return tempera.Mostrar();
            }
            else
            {
                return mensaje;
            }
        }

        public static bool operator == (Tempera t1,Tempera t2)
        {
            if(!Object.Equals(t1,null) && !Object.Equals(t2,null))
            {
                if ((t1.color == t2.color) && (t1.marca == t2.marca))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator + (Tempera tempera, int num)
        {
            tempera.cantidad = tempera.cantidad + num;
            return tempera;
        }

        public static Tempera operator + (Tempera tempera1, Tempera tempera2)
        {
            if(tempera1==tempera2)
            {
                tempera1.cantidad=tempera1.cantidad+tempera2.cantidad;
            }
            return tempera1;
        }
    }  
}
