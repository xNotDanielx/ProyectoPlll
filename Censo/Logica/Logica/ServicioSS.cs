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
        int Count =0;
        public int ContarAfiliado()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Afliado;
            }
            return Count;

        }
        public int ContarV_Conflicto()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Victima_Conflicto;
            }
            return Count;

        }
        public int ContarA_Estudio()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Acceso_Estudio;
            }
            return Count;

        }
        public int ContarArhuaco()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if(item.Etnia=="Arhuaco")
                {
                    Count++;
                }           
            }
            return Count;

        }
        public int ContarKogui()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Kogui")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarKankuamo()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Kankuamo")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarWiwa()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Wiwa")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarYucpa()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Yucpa")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarChimila()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Chimila")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarNinguna_E()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Ninguna")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarSin_Educacion()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                Count = Count + item.Acceso_Estudio;
            }
            return Count;

        }
        public int ContarE_Formal()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Sin Educacion")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarPrimaria()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Primaria")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarSecundaria()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Secundaria")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarTecnicos()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Tecnica")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarUniversitario()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Universitaria")
                {
                    Count++;
                }
            }
            return Count;

        }
        public int ContarE_Otro()
        {
            Count = 0;
            foreach (var item in GetAll())
            {
                if (item.Etnia == "Otro")
                {
                    Count++;
                }
            }
            return Count;

        }
    }
}
