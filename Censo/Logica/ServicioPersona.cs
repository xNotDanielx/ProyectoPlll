using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        void Refrescar()
        {
            try
            {
                personas = archivo.consultar();
            }
            catch (Exception)
            {

            }
        }
        public bool Eliminar_Cuenta(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Bucar_Cuenta(Persona persona)
        {
            Refrescar();
            bool Verificar = false;       
            foreach(var item  in personas)
            {
                if (item.Numero_Documento.Equals(persona.Numero_Documento) & item.Contraseña.Equals(persona.Contraseña))
                {
                    Verificar = true;
                }
            }
            return Verificar;         
        }

        public List<Persona> Obtener_Cuentas()
        {
            throw new NotImplementedException();
        }

        public bool Exist(Persona persona)
        {
            bool exist = false;
            foreach (var item in personas)
            {
                if (item.Equals(persona)) { exist = true; }
            }

            return exist;
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
