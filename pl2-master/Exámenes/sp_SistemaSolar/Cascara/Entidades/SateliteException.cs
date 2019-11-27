using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SateliteException : Exception
    {
        public SateliteException():base("No se puede crear el satelite.")
        {

        }
    }
}
