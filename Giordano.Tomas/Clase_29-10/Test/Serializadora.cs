using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Serializadora
    {
        public static bool Serializar(IXML i)
        {
            return i.Guardar(@"C:\Users\alumno\Desktop\");
        }

        public static bool Deserializar(IXML i,out object salida)
        {
            return i.Leer(@"C:\Users\alumno\Desktop\",out salida);
        }
    }
}
