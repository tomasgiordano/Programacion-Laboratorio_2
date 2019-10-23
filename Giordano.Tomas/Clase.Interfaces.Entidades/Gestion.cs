using System;
using System.Collections.Generic;
using System.Text;

namespace Clase.Interfaces.Entidades
{
    public static class Gestion
    {
        public static double MostrarImpuestoNacional(IAfip bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }

        public static double MostrarImpuestoProvincial(IArba bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
