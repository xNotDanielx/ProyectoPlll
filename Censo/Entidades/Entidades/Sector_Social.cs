using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector_Social
    {
        public Sector_Social() { }
        public int IDSector { get; set; }
        public int Afliado { get; set; }
        public int Victima_Conflicto { get; set; }
        public string Etnia { get; set; }
        public int Acceso_Estudio { get; set; }
        public int Servicio_Transporte { get; set; }
        public string Estado_Civil { get; set; }
        public string NivelEducacion { get; set; }

        public Sector_Social(int idsector,int afliado, int victima_Conflicto, string etnia, int acceso_Estudio, int servicio_Transporte, string estado_Civil, string nivel)
        {
            IDSector = idsector;
            Afliado = afliado;
            Victima_Conflicto = victima_Conflicto;
            Etnia = etnia;
            Acceso_Estudio = acceso_Estudio;
            Servicio_Transporte = servicio_Transporte;
            Estado_Civil = estado_Civil;
            NivelEducacion = nivel;
        }

        public override string ToString()
        {
            return $"{IDSector};{Afliado};{Victima_Conflicto};{Etnia};{Acceso_Estudio};{Servicio_Transporte};{Estado_Civil};{NivelEducacion}";
        }

    }
}
