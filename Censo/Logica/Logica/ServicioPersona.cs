using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Persona> GetAll()
        {
            try
            {
                if (personas.Count == 0) return null;
                Refresh();
                return personas;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Buscar_Persona(Persona persona)
        {
            Refresh();
            bool Verificar = false;
            if (GetAll() != null)
            {
                foreach (var item in GetAll())
                {
                    Console.WriteLine("culo"+item.Documento);
                    if (item.Documento.Equals(persona.Documento))
                    {                      
                        Verificar = true;
                    }
                }
            }
            else
            {
               Verificar = false;
            }
            return Verificar;
        }

        public List<Persona> Obtener_Informacion(Persona persona)
        {
            try
            {
                Refresh();
                List<Persona> ListaPorNombre = new List<Persona>();
                foreach (var item in GetAll())
                {
                    if (item.Documento.Equals(persona.Documento))
                    {
                        ListaPorNombre.Add(item);
                    }
                }

                return ListaPorNombre;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool Eliminar(Persona persona)
        {
            throw new NotImplementedException();
        }
    }
}
