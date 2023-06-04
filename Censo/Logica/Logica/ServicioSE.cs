using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSE : ICrud<Sector_Economico>
    {
        Datos.RepositorioSE repositorioSE;
        List<Sector_Economico> sectorE;

        public ServicioSE(string conexion)
        {
            repositorioSE = new Datos.RepositorioSE(conexion);
        }

        public void Delete(Sector_Economico SE)
        {
            repositorioSE.Delete(SE);
        }

        public List<Sector_Economico> GetAll()
        {
            return repositorioSE.GetAll();
        }

        public void Insertar(Sector_Economico SE)
        {
            repositorioSE.Insert(SE);
        }

        public void Update(Sector_Economico SE)
        {
            repositorioSE.Update(SE);
        }

        public void insertarDoc(String Doc)
        {
            repositorioSE.InsertDoc(Doc);
        }

    }
}
