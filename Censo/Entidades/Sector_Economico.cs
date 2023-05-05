using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sector_Economico
    {
        public int Empleado { get; set; }
        public int Propietario_Negocio { get; set; }
        public int Trabajador_Privado { get; set; }
        public int Contratista_Independiente { get; set; }
        public int Pensionado { get; set; }
        public int Subsidiado { get; set; }
        public int Accionistas { get; set; }
        public int Trabajador_Publico { get; set; }
        public int Ingreso_Actividades { get; set; }
        public int Desempleado { get; set; }
        public string Sector_Completado { get; set; }

        public Sector_Economico() { }
        public Sector_Economico(int empleado, int propietario_Negocio, int trabajador_Privado, int contratista_Independiente, int pensionado, int subsidiado, int accionistas, int trabajador_Publico, int ingreso_Actividades, int desempleado,string sector_completado)
        {
            Empleado = empleado;
            Propietario_Negocio = propietario_Negocio;
            Trabajador_Privado = trabajador_Privado;
            Contratista_Independiente = contratista_Independiente;
            Pensionado = pensionado;
            Subsidiado = subsidiado;
            Accionistas = accionistas;
            Trabajador_Publico = trabajador_Publico;
            Ingreso_Actividades = ingreso_Actividades;
            Desempleado = desempleado;
            Sector_Completado = sector_completado;
        }

        public override string ToString()
        {
            return $"{Empleado};{Propietario_Negocio};{Trabajador_Privado};{Contratista_Independiente};{Pensionado};{Subsidiado};{Accionistas};{Trabajador_Publico};{Ingreso_Actividades};{Desempleado};{Sector_Completado}";
        }
    }
}
