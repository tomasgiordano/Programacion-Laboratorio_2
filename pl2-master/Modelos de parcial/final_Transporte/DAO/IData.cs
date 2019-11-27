using System.Collections.Generic;

namespace Datos
{
    public interface IData<T>
    {
        void Guardar(T entity);
    }
}