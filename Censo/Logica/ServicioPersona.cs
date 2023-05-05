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
    public class ServicioPersona
    {
        Archivo archivo = new Archivo();
        List<Persona> personas;
        List<Login> logins;
        List<Sector_Economico> sectorE;
        List<Sector_Hogar> sectorH;
        List<Sector_Social> sectorS;

        public ServicioPersona()
        {
            Refresh(); 
        }

        public string Añadir_Persona(Persona persona)
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

        public string Añadir_Sectores(Sector_Economico SE, Sector_Social SS, Sector_Hogar SH) { 
            try
            {
                if (SE == null || SH == null || SS == null)
                {
                    return "No se puede guardar un valor NULL";
                }
                else
                {
                    archivo.GuardarSector_Economico(SE);
                    archivo.GuardarSector_Hogar(SH);
                    archivo.GuardarSector_Social(SS);
                    return "Guardado...";
                }
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }

        void Refresh()
        {
            try
            {
                personas = archivo.consultarPersona();
                sectorE = archivo.consultarSE();
                sectorH = archivo.consultarSH();
                sectorS = archivo.consultarSS();
            }
            catch (Exception)
            {

            }
        }
        public bool Eliminar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public bool Buscar_Cuenta(Login login)
        {
            Refresh();
            bool Verificar = false;       
            foreach(var item  in logins)
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
