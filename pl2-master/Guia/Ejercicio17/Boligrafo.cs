using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        #region ATRIBUTOS
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;
        #endregion

        #region CONSTRUCTORES

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this._color = color;
            this._tinta = tinta;
        }

        #endregion

        #region METODOS
        public ConsoleColor GetColor()
        {
            return this._color;
        }

        public short GetTinta()
        {
            return this._tinta;
        }

        private void SetTinta(short tinta)
        {

            this._tinta += tinta;
            //Controlar que no se pase del rango 0 - 100 después de agregarle tinta.

            if(this.GetTinta() > cantidadTintaMaxima)
            {
                this._tinta = cantidadTintaMaxima;
            }
            if (this.GetTinta() < 0)
            {
                this._tinta = 0;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            dibujo = "";

            if(gasto > 0 && this.GetTinta() > 0)
            {
                if(gasto > this.GetTinta())
                {
                    gasto = this.GetTinta();
                }

                this.SetTinta((short)(gasto * -1));

                for(int i = gasto; i > 0; i--)
                {
                    dibujo += "*";
                }

                Console.ForegroundColor = this.GetColor();
                Console.WriteLine("{0}: {1}",dibujo, gasto);
                Console.ForegroundColor = ConsoleColor.Gray;

                return true;
            }


            return false;
        }
        
        
        #endregion


    }
}
