using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioLogin
    {
        Archivo archivo = new Archivo();
        List<Login> logins;

        public ServicioLogin()
        {
            Refresh();
        }

        void Refresh()
        {
            try
            {
                logins = archivo.consultarCuenta();
            }
            catch (Exception)
            {

            }
        }

        public List<Login> GetAll()
        {
            Refresh();
            if (logins.Count == 0) return null;

            return logins;
        }

        public string Añadir_Cuentas(Login login)
        {
            try
            {
                if (login == null)
                {
                    return "No se puede guardar una persona con valor NULL";
                }
                else
                {
                    archivo.Guardar_Login(login);
                    return "Guardado...";
                }
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }
        public bool Buscar_Cuenta(string doc, string contra)
        {
            Refresh(); 
            bool Verificar = false;
            foreach (var item in GetAll())
            {
                if (item.Numero_Documento.Equals(doc) & item.Contraseña.Equals(contra))
                {
                    Verificar = true;
                }
                else
                {
                    Verificar = false;
                }
            }
            return Verificar;
        }
    }
}
