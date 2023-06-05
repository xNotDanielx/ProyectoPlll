using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        int Count = 0;
        public int ContarEmpleado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if(item.Empleado == 1)
                {
                    Count = Count + item.Empleado;
                }               
            }
            return Count;
        }
        public int ContarPropietario()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Propietario_Negocio;
            }
            return Count;
        }
        public int ContarT_Privado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Trabajador_Privado;
            }
            return Count;
        }
        public int ContarC_Independiente()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Contratista_Independiente;
            }
            return Count;
        }
        public int ContarPensionado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Pensionado;
            }
            return Count;
        }
        public int ContarSubisidiado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Subsidiado;
            }
            return Count;
        }
        public int ContarAccionista()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Accionistas;
            }
            return Count;
        }
        public int ContarT_Publico()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Trabajador_Publico;
            }
            return Count;
        }
        public int ContarI_Actividades()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Ingreso_Actividades;
            }
            return Count;
        }
        public int ContarDesempleado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Desempleado;
            }
            return Count;
        }
        public int ContarEstrato1()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "1")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarEstrato2()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "2")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarEstrato3()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "3")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarEstrato4()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "4")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarEstrato5()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "5")
                {
                    Count++;
                }
            }
            return Count;
        }
        public int ContarEstrato6()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Estrato == "6")
                {
                    Count++;
                }
            }
            return Count;
        }
    }
}
