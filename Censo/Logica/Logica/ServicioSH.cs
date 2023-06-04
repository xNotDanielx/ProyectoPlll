using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioSH : ICrud<Sector_Hogar>
    {
        Datos.RepositorioSH repositorioSH;
        List<Sector_Hogar> sectorH;
        public ServicioSH(string conexion)
        {
            repositorioSH = new Datos.RepositorioSH(conexion);
        }

        public void Delete(Sector_Hogar SH)
        {
            repositorioSH.Delete(SH);
        }

        public List<Sector_Hogar> GetAll()
        {
            return repositorioSH.GetAll();
        }

        public void Insertar(Sector_Hogar SH)
        {
            repositorioSH.Insert(SH);
        }

        public void Update(Sector_Hogar SH)
        {
            repositorioSH.Update(SH);
        }
        public void insertarDoc(String Doc)
        {
            repositorioSH.InsertDoc(Doc);
        }
    }
}
