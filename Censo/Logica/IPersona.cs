using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IPersona<T>
    {
        String add(T persona);
        List<T> GetAll();
        bool DeletePersona(T persona);
        bool UpdatePersona(T persona);
        void GetByCc(T cedula);
        List<T> GetByName(String name);
        bool Exist (T persona);
    }
}
