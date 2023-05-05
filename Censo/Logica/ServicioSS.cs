using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSS : ICenso<Sector_Social>
    {
        Archivo archivo = new Archivo();
        List<Sector_Social> sectorS;

        public ServicioSS()
        {
            Refresh();
        }

        public string Añadir(Sector_Social Sector)
        {
            try
            {
                if (Sector == null)
                {
                    return "No se puede guardar un valor NULL";
                }
                else
                {
                    archivo.GuardarSector_Social(Sector);
                    return "Guardado...";
                }
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }

        public List<Sector_Social> GetAll()
        {
            Refresh();
            if (sectorS.Count == 0) return null;

            return sectorS;
        }

        public void Refresh()
        {
            try
            {
                sectorS = archivo.consultarSS();
            }
            catch (Exception)
            {

            }
        }
    }
}
