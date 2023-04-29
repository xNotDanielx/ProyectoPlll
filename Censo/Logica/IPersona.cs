using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IPersona<T>
    {
        void Añadir_Cuenta(T persona);
        bool Eliminar_Cuenta(T persona);
        bool Bucar_Cuenta(T persona);
        List<T> Obtener_Cuentas();
        List<T> GetByName(String name);
        bool UpdatePersona(T persona);

    }
}
