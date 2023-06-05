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
        int Count = 0;
        public int ContarRural()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Zona == "Rural")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarUrbana()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Zona == "Urbana")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarAgua()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Servicio_Agua;
            }
            return Count;

        }
        public int ContarLuz()
        {
            Count = 0;
            foreach (var item in GetAll())
                {
                    Count = Count + item.Servicio_Luz;
                }
                return Count;

        }
        public int ContarGas()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Servicio_Gas;
            }
            return Count;

        }
        public int ContarSaneamiento()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Saneamiento;
            }
            return Count;

        }
        public int ContarVehiculo()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Vehiculo;
            }
            return Count;

        }
        public int ContarInternet()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Internet;
            }
            return Count;

        }
    }
}
