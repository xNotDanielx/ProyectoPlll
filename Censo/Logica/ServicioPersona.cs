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
    public class ServicioPersona : ICenso<Persona>
    {        
        List<Persona> personas;
        Archivo archivo = new Archivo();

        public ServicioPersona()
        {
            Refresh();
        }

        public string Añadir(Persona persona)
        {
            try
            {
                if (persona == null) 
                { 
                    return "No se puede guardar una persona con valor NULL";
                }
                else
                {
                    archivo.Guardar_Persona(persona);
                    return "Guardado...";
                }                
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }
        public List<Persona> GetAll()
        {
            Refresh();
            if (personas.Count == 0) return null;

            return personas;
        }



        public void Refresh()
        {
            try
            {
                personas = archivo.consultarPersona();
            }
            catch (Exception)
            {

            }
        }


        public bool Eliminar(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
