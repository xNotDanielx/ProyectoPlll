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
    public class ServicioLogin : ICrud<Login>
    {
        Datos.RepositorioLogin repositorioLogin;

        public ServicioLogin(string conexion)
        {
            repositorioLogin = new RepositorioLogin(conexion);
        }
        public void Insertar(Login PersonaLog)
        {
            repositorioLogin.Insert(PersonaLog);
        }

        public void Delete(Login PersonaLog)
        {
            repositorioLogin.Delete(PersonaLog);
        }

        public void Update(Login PersonaLog)
        {
            repositorioLogin.Update(PersonaLog);
        }

        public DataTable GetBy(String Columna, String Doc)
        {
            return repositorioLogin.GetBy(Columna, Doc);
        }

            public List<Login> GetAll()
        {
            return repositorioLogin.GetAll();
        }

        public bool Buscar_Cuenta(Login login)
        {
            bool Verificar = false;
            foreach (var item in GetAll())
            {
                if (item.Numero_Documento.Equals(login.Numero_Documento) & item.Contraseña.Equals(login.Contraseña))
                {
                    Verificar = true;
                }
            }
            return Verificar;
        }

        public List<Login> Obtener_Informacion(Login log)
        {
            try
            {
                List<Login> ListaPorND = new List<Login>();
                if (GetAll() == null)
                {
                    return null;
                }
                else
                {
                    foreach (var item in GetAll())
                    {
                        if (item.Numero_Documento.Equals(log.Numero_Documento))
                        {
                            ListaPorND.Add(item);
                        }
                    }
                }
                return ListaPorND;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public bool Buscar_Persona(Login login)
        {
            bool Verificar = false;
            foreach (var item in GetAll())
            {
                if (item.Numero_Documento.Equals(login.Numero_Documento))
                {
                    Verificar = true;
                }
            }
            return Verificar;
        }
        int Count = 0;
        public int ContarCC()
        {
            foreach (var item in GetAll())
            {
                if (item.Tipo_Documento == "CC")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarCE()
        {
            foreach (var item in GetAll())
            {
                if (item.Tipo_Documento == "CE")
                {
                    Count++;
                }
            }
            return Count;

        }
    }
}

