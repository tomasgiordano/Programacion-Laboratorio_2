using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_09.Entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        public string Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public int CantidadPaginas
        {
            get
            {
                int cantidad=0;
                foreach(Capitulo a in this.capitulos)
                {
                    cantidad += a.Paginas;
                }
                return cantidad;
            }
        }

        public Libro(string titulo,string autor)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.capitulos = new List<Capitulo>();
        }

        public int CantidadCapitulos
        {
            get { return this.capitulos.Count; }
        }

        public Capitulo this[int index]
        {
            get
            {
                if (index < 0 || index >= this.capitulos.Count)
                {
                    return null;
                }
                else
                {
                    return this.capitulos[index];
                }
            }

            set
            {
                if (index >= this.capitulos.Count)
                {
                    this.capitulos.Add(value);
                }
                else if (index < 0)
                {
                    
                }
                else
                {
                    this.capitulos[index] = value;
                }
            }
        }

    }
}
