using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_06.Entidades
{
    public class Paleta
    {
        
          private Tempera[] colores;
          private int cantidadMaximaColores;


          private Paleta(int num)
          {
              this.colores = new Tempera[num];
              this.cantidadMaximaColores = num;
          }

          private Paleta() : this(5)
          {

          }

            public static implicit operator Paleta(int num)
            {
                Paleta paleta = new Paleta(num);
                return paleta;
            }

            public string Mostrar()
            {
                string mensaje = "";

                for (int i = 0; i < this.colores.Length; i++)
                {
                    mensaje = mensaje + (string)this.colores[i] + "\n";
                }

                mensaje = mensaje + "Cantidad maxima: " + this.cantidadMaximaColores.ToString();

                return mensaje;
            }

            public static bool operator ==(Paleta paleta, Tempera tempera)
            {
                bool auxBool = false;

                if (!Object.Equals(paleta, null) && !Object.Equals(tempera, null))
                {
                    for (int i = 0; i < paleta.colores.Length; i++)
                    {
                        if (paleta.colores[i] == tempera)
                        {
                            auxBool = true;
                        }
                    }
                }
                else
                {
                    return false;
                }
                return auxBool;
            }

            public static bool operator !=(Paleta paleta, Tempera tempera)
            {
                return !(paleta == tempera);
            }

            private int ObtenerLugarLibre()
            {
                int index = -1;

                for (int i = 0; i < this.colores.Length; i++)
                {
                    if (this.colores[i] == null)
                    {
                        index = i;
                    }
                }
                return index;
            }

            public static Paleta operator +(Paleta paleta, Tempera tempera)
            {
                if (Object.Equals(paleta, null) || Object.Equals(tempera, null))
                {
                    return paleta;
                }
                else if (paleta == tempera)
                {
                    int index = Array.IndexOf(paleta.colores, tempera);
                    paleta.colores[index] += tempera;
                }
                else if (paleta.ObtenerLugarLibre() != -1)
                {
                    int index = paleta.ObtenerLugarLibre();
                    paleta.colores[index] = tempera;
                }
                return paleta;
            }
        }
    }
