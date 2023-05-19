using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSE : ICenso<Sector_Economico>
    {
        List<Sector_Economico> sectorE;
        Archivo archivo = new Archivo();

        public ServicioSE()
        {
            Refresh();
        }

        public string Añadir(Sector_Economico Sector)
        {
            try
            {
                if (Sector == null)
                {
                    return "No se puede guardar un valor NULL";
                }
                else
                {
                    archivo.GuardarSector_Economico(Sector);
                    return "Guardado...";
                }
            }
            catch (Exception)
            {
                return "Error al guardar";
            }
        }

        public List<Sector_Economico> GetAll()
        {
            Refresh();
            if (sectorE.Count == 0) return null;

            return sectorE;
        }

        public void Refresh()
        {
            try
            {
                sectorE = archivo.consultarSE();
            }
            catch (Exception)
            {

            }
        }

        public List<Sector_Economico> Obtener_Informacion(Sector_Economico se)
        {
            try
            {
                Refresh();
                List<Sector_Economico> ListaSectorE = new List<Sector_Economico>();
                foreach (var item in GetAll())
                {
                    if (item.IDSector.Equals(se.IDSector))
                    {
                        ListaSectorE.Add(item);
                    }
                }

                return ListaSectorE;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
