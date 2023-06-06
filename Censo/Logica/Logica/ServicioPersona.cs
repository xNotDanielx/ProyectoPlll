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

        public void updateSectorComplete(string Sector, string Doc)
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
            Count = 0;
            foreach (var item in GetAll())
            {
                Count++;
            }
            return Count;
        }

        public int ContarHombres()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Sexo == "Masculino")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarMujeres()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Sexo == "Femenino")
                {
                    Count++;
                }
            }
            return Count;
        }

        public int ContarHogar()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Tipo_Vivienda == "Hogar")
                {
                    Count++;
                }
            }
            return Count;
        }

        public int ContarApartamento()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Tipo_Vivienda == "Apartamento")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarMayorEdad()
        {
            Count = 0;
            foreach (var item in GetAll())
            {                
                if (int.Parse(item.Edad) >= 18 )
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarMenorEdad()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (int.Parse(item.Edad) <= 18)
                {
                    Count++;
                }
            }
            return Count;
        }      

    }
}
