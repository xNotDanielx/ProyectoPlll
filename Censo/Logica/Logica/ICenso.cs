using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICenso<T>
    {
        void Refresh();
        String Añadir(T Entidad);
        List<T> GetAll();
        List<T> Obtener_Informacion(T Entidad);
    }
}
