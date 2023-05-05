﻿using Datos;
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
        public bool Buscar_Cuenta(Login login)
        {
            Refresh();
            bool Verificar = false;
            foreach (var item in logins)
            {
                if (item.Numero_Documento.Equals(login.Numero_Documento) & item.Contraseña.Equals(login.Contraseña))
                {
                    Verificar = true;
                }
            }
            return Verificar;
        }
    }
}
