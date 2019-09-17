using System;

namespace Clase_09.Entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros;
        private static Random generadorDePaginas;

        public int Numero
        {
            get { return this.numero; }
            
        }
        public string Titulo
        {
            
            set { this.titulo=value;}
            get { return this.titulo; }
        }
        public int Paginas
        {
            get { return this.paginas; }
        }

        static Capitulo()
        {

            Capitulo.generadorDeNumeros = new Random();
            Capitulo.generadorDePaginas = new Random();
        }
        private Capitulo(int num, string tit, int pag)
        {
            this.numero = num;
            this.paginas = pag;
            this.titulo = tit;
        }

        public static implicit operator Capitulo(string cadena)
        {
            Capitulo cap = new Capitulo(Capitulo.generadorDeNumeros.Next(1,65),cadena,Capitulo.generadorDePaginas.Next(15,233));
          
           return cap;
            
        }

        public static bool operator ==(Capitulo capitulo1, Capitulo capitulo2)
        {
            if(capitulo1.numero==capitulo2.numero&&capitulo1.titulo==capitulo2.titulo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Capitulo capitulo1,Capitulo capitulo2)
        {
            return !(capitulo1 == capitulo2);
        }
            


    }
}
