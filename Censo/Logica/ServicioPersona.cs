using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPersona : IPersona<Persona>
    {
        public string add(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersona(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Persona persona)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetByCc(Persona cedula)
        {
            throw new NotImplementedException();
        }

        public List<Persona> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePersona(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
