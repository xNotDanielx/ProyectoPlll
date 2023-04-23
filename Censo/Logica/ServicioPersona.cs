using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPersona : IPersona<Persona>
    {
        Archivo archivo = new Archivo();
        List<Persona> personas;

        public void Añadir_Cuenta(Persona persona)
        {
            try
            {
                if (persona == null) { return; }
                archivo.guardar_Cuentas(persona);
                //return $"contacto {contacto.Nombre} guardado...";
            }
            catch (Exception)
            {
                return;
            }
        }

        public bool Eliminar_Cuenta(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Bucar_Cuenta(Persona persona)
        {
            throw new NotImplementedException();
        }

        public List<Persona> Obtener_Cuentas()
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
