using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSH : ICenso<Sector_Hogar>
    {
        Archivo archivo = new Archivo();
        List<Sector_Hogar> sectorH;
        public ServicioSH()
        {
            Refresh();
        }

        public string Añadir(Sector_Hogar Sector)
        {
            try
            {
                if (Sector == null)
                {
                    return "No se puede guardar un valor NULL";
                }
                else
                {
                    archivo.GuardarSector_Hogar(Sector);
                    return "Guardado...";
                }
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }

        public List<Sector_Hogar> GetAll()
        {
            Refresh();
            if (sectorH.Count == 0) return null;

            return sectorH;
        }

        public void Refresh()
        {
            try
            {
                sectorH = archivo.consultarSH();
            }
            catch (Exception)
            {

            }
        }
    }
}
