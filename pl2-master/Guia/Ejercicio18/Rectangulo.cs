﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        /*
         * Las X van a ser igual siempre
         * Las Y van a ser igual siempre
         */

        private float area;
        private float perimetro;

        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3) {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.X,vertice3.Y);
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.X, vertice1.Y);
        }

        public float Area() {
           return this.area;
        }

        public float Perimetro() {
            return this.perimetro;
        }





    }
}
