using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector_Hogar
    {
        public int Rural { get; set; }
        public int Urbana { get; set; }
        public int Propietario { get; set; }
        public int Servicio_Agua { get; set; }
        public int No_servicio_Agua { get; set; }
        public int Servicio_Luz { get; set; }
        public int No_servicio_Luz { get; set; }
        public int Sericio_Gas { get; set; }
        public int No_sericio_Gas { get; set; }
        public int Saneamiento { get; set; }
        public int No_Saneamiento { get; set; }
        public int Ingreso_Alto { get; set; }
        public int Ingreso_Medio { get; set; }
        public int Ingreso_Bajo { get; set; }
        public int Estrato { get; set; }

        public Sector_Hogar(int rural, int urbana, int propietario, int servicio_Agua, int no_servicio_Agua, int servicio_Luz, int no_servicio_Luz, int sericio_Gas, int no_sericio_Gas, int saneamiento, int no_Saneamiento, int ingreso_Alto, int ingreso_Medio, int ingreso_Bajo, int estrato)
        {
            Rural = rural;
            Urbana = urbana;
            this.Propietario = propietario;
            Servicio_Agua = servicio_Agua;
            No_servicio_Agua = no_servicio_Agua;
            Servicio_Luz = servicio_Luz;
            No_servicio_Luz = no_servicio_Luz;
            Sericio_Gas = sericio_Gas;
            No_sericio_Gas = no_sericio_Gas;
            Saneamiento = saneamiento;
            No_Saneamiento = no_Saneamiento;
            Ingreso_Alto = ingreso_Alto;
            Ingreso_Medio = ingreso_Medio;
            Ingreso_Bajo = ingreso_Bajo;
            Estrato = estrato;
        }
        public override string ToString()
        {
            return $"{Rural};{Urbana};{Propietario};{Servicio_Agua};{No_servicio_Agua};{No_servicio_Luz};{Sericio_Gas};{No_sericio_Gas};{Saneamiento};{No_Saneamiento};{Ingreso_Alto};{Ingreso_Medio};{Ingreso_Bajo};{Estrato}";
        }
    }
}
