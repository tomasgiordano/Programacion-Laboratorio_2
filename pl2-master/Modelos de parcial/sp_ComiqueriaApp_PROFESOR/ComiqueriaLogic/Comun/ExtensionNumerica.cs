using System;

namespace ComiqueriaLogic
{
    public static class ExtensionNumerica
    {
        public static string FormatearPrecio(this Double valor)
        {
            return String.Format("${0:0.00}", valor);
        }
    }
}
