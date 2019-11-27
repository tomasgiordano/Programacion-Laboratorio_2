

namespace Entidades
{
    public interface IAvion
    {
        Avion.EstadoVuelo Estado { get; }
        void Despegar();
        void Estrellar();
    }
}
