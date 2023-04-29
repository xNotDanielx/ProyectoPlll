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
        public int Arhuaco{ get; set; }
        public int Kogui { get; set; }
        public int Kankuamo { get; set; }
        public int Wiwa { get; set; }
        public int Yucpa { get; set; }
        public int Chimila { get; set; }
        public int Acceso_Estudio { get; set; }
        public int Servicio_Transporte { get; set; }
        public int Estado_Civil { get; set; }
        public int Sin_Educacion { get; set; }
        public int Educacio_Primaria { get; set; }
        public int Educacio_Tecnica { get; set; }
        public int Educacion_universitaria { get; set; }
        public String Etnia { get; set; }

        public Sector_Social(int afliado, int victima_Conflicto, int arhuaco, int kogui, int kankuamo, int wiwa, int yucpa, int chimila, int acceso_Estudio, int servicio_Transporte, int estado_Civil, int sin_Educacion, int educacio_Primaria, int educacio_Tecnica, int educacion_universitaria,string etnia )
        {
            Afliado = afliado;
            Victima_Conflicto = victima_Conflicto;
            Arhuaco = arhuaco;
            Kogui = kogui;
            Kankuamo = kankuamo;
            Wiwa = wiwa;
            Yucpa = yucpa;
            Chimila = chimila;
            Acceso_Estudio = acceso_Estudio;
            Servicio_Transporte = servicio_Transporte;
            Estado_Civil = estado_Civil;
            Sin_Educacion = sin_Educacion;
            Educacio_Primaria = educacio_Primaria;
            Educacio_Tecnica = educacio_Tecnica;
            Educacion_universitaria = educacion_universitaria;
            Etnia = etnia;
        }
        
    }
}
