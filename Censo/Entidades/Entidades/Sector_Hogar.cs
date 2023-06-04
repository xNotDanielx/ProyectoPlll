using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector_Hogar
    {
        public Sector_Hogar() { }
        public string Documento { get; set; }
        public String Zona { get; set; }
        public int Propietario { get; set; }
        public int Servicio_Agua { get; set; }
        public int Servicio_Luz { get; set; }
        public int Servicio_Gas { get; set; }
        public int Saneamiento { get; set; }
        public int Adicional { get; set; }
        public String Habitaciones { get; set; }
        public String Baños { get; set; }
        public String Tipo_Vivienda { get; set; }
        public String Ingreso { get; set; }
        public int Internet { get; set; }
        public int Cable { get; set; }
        public int Telefono { get; set; }
        public int Vehiculo { get; set; }
        public Sector_Hogar(int idSector, string zona, int propietario, int servicio_Agua, int servicio_Luz, int servicio_Gas, int saneamiento, int adicional, String habitaciones, String baños, string tipoVivienda, string ingreso, int internet, int cable, int telefono, int vehiculo, int estrato, string sector_Completado)
        {
            Zona = zona;
            Propietario = propietario;
            Servicio_Agua = servicio_Agua;
            Servicio_Luz = servicio_Luz;
            Servicio_Gas = servicio_Gas;
            Saneamiento = saneamiento;
            Adicional = adicional;
            Habitaciones = habitaciones;
            Baños = baños;
            Tipo_Vivienda = tipoVivienda;
            Ingreso = ingreso;
            Internet = internet;
            Cable = cable;
            Telefono = telefono;
            Vehiculo = vehiculo;
        }
        public override string ToString()
        {
            return $"{Zona};{Propietario};{Servicio_Agua};{Servicio_Luz};{Servicio_Gas};{Saneamiento};{Adicional};{Habitaciones};{Baños};{Tipo_Vivienda};{Ingreso};{Internet};{Cable};{Telefono};{Vehiculo}";
        }
    }
}
