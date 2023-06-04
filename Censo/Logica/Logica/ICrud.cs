using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICrud<T>
    {
        void Insertar(T Entidad);
        void Delete(T Entidad);
        void Update(T Entidad);
        List<T> GetAll();
    }
}
