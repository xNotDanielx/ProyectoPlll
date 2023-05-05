using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector_Social
    {
        public int Afliado { get; set; }
        public int Victima_Conflicto { get; set; }
        public string Etnia { get; set; }
        public int Acceso_Estudio { get; set; }
        public int Servicio_Transporte { get; set; }
        public string Estado_Civil { get; set; }
        public string NivelEducacion { get; set; }
<<<<<<< HEAD
        public string Sector_Completado { get; set; }
=======
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2

        public Sector_Social()
        {
            
        }

<<<<<<< HEAD
        public Sector_Social(int afliado, int victima_Conflicto, string etnia, int acceso_Estudio, int servicio_Transporte, string estado_Civil, string nivel, string sector_completado)
=======
        public Sector_Social(int afliado, int victima_Conflicto, string etnia, int acceso_Estudio, int servicio_Transporte, string estado_Civil, string nivel)
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        {
            Afliado = afliado;
            Victima_Conflicto = victima_Conflicto;
            Etnia = etnia;
            Acceso_Estudio = acceso_Estudio;
            Servicio_Transporte = servicio_Transporte;
            Estado_Civil = estado_Civil;
            NivelEducacion = nivel;
<<<<<<< HEAD
            Sector_Completado = sector_completado;

=======
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        }

        public override string ToString()
        {
<<<<<<< HEAD
            return $"{Afliado};{Victima_Conflicto};{Etnia};{Acceso_Estudio};{Servicio_Transporte};{Estado_Civil};{NivelEducacion};{Sector_Completado}";
=======
            return $"{Afliado};{Victima_Conflicto};{Etnia};{Acceso_Estudio};{Servicio_Transporte};{Estado_Civil};{NivelEducacion}";
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        }

    }
}
