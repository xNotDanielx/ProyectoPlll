using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSS : ICrud<Sector_Social>
    {
        Datos.RepositorioSS repositorioSS;
        List<Sector_Social> sectorS;

        public ServicioSS(string conexion)
        {
            repositorioSS = new Datos.RepositorioSS(conexion);
        }

        public void Delete(Sector_Social SS)
        {
            repositorioSS.Delete(SS);
        }

        public List<Sector_Social> GetAll()
        {
            return repositorioSS.GetAll();
        }

        public void Insertar(Sector_Social SS)
        {
            repositorioSS.Insert(SS);
        }

        public void Update(Sector_Social SS)
        {
            repositorioSS.Update(SS);
        }

        public void insertarDoc(String Doc)
        {
            repositorioSS.InsertDoc(Doc);
        }
    }
}
