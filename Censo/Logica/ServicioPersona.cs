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

        public bool Buscar_Cuenta(Persona persona)
        {
            Refresh();
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
