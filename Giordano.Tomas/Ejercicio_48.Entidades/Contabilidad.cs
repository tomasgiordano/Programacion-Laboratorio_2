using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_48.Entidades
{
    public class Contabilidad<T,U>where T : Documento where U : Documento ,new()
    {
        private List<T> egresos;
        private List<U> ingresos;

        public static Contabilidad<T,U> operator +(Contabilidad<T,U>c,T egreso)
        {
            c.egresos.Add(egreso);
            Console.WriteLine("Se agrego: "+T);
            return c;
        }
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingresos)
        {
            c.ingresos.Add(ingresos);
            Console.WriteLine("Se agrego: "+U);
            return c;
        }
    }
}
