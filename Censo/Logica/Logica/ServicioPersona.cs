using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPersona : ICrud<Persona>
    {
        Datos.RepositorioPersona repositorioPersona;
        List<Persona> personas;

        public ServicioPersona(string conexion)
        {
            repositorioPersona = new Datos.RepositorioPersona(conexion);
        }     

        public void Insertar(Persona Persona)
        {
            repositorioPersona.Insert(Persona);
        }

        public void Delete(Persona Persona)
        {
            repositorioPersona.Delete(Persona);
        }

        public void Update(Persona Persona)
        {
            repositorioPersona.Update(Persona);
        }

        public List<Persona> GetAll()
        {
            return repositorioPersona.GetAll();
        }

        public DataTable GetBy(String Columna, String Doc)
        {
            return repositorioPersona.GetBy(Columna, Doc);
        }

        public void updateSectorComplete(String Sector, String Doc)
        {
            repositorioPersona.UpdateSectorComplete(Sector, Doc);
        }

        public bool Buscar_Persona(Persona persona)
        {
            bool Verificar = false;
            if (GetAll() != null)
            {
                foreach (var item in GetAll())
                {
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
                List<Persona> ListaPorND = new List<Persona>();
                foreach (var item in GetAll())
                {
                    if (item.Documento.Equals(persona.Documento))
                    {
                        ListaPorND.Add(item);
                    }
                }

                return ListaPorND;
            }
            catch (Exception)
            {
                return null;
            }

        }

        int Count = 0;
        public int Cuentas_Registradas()
        {
            foreach (var item in GetAll())
            {
                Count ++;
            }
            return Count;
        }

        public int ContarHombres()
        {
            foreach (var item in GetAll())
            {
                Count++;
            }
            return Count;
        }

        public int ContarMujeres()
        {
            foreach (var item in GetAll())
            {
                Count++;
            }
            return Count;
        }
    }
}
