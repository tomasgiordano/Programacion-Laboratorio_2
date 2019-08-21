using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.ArmarFormatoMensaje());
        }

        private static string ArmarFormatoMensaje()
        {
            string encuadrado="";
            int len;
            int i=0;

            len = Sello.mensaje.Length;

            while(len+2>i)
            {
                encuadrado = encuadrado+ "*";
                i++;
            }
            encuadrado = encuadrado+"\n"+"*" + Sello.mensaje + "*"+"\n";
            i = 0;
            while (len+2>i)
            {
                encuadrado = encuadrado + "*";
                i++;
            }

            return encuadrado;
        }
    }
}
