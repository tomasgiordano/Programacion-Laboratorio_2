using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public interface IAstro
    {
        Thread HiloOrbita { get; set; }
        Thread HiloRotacion { get; set; }

        string Orbitar();
        string Rotar();
        void RunEvntOrb();
        void RunEvntRotar();
                
    }
}
