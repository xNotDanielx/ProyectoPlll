using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public Persona() { }
        public string Documento { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Sexo { get; set; }
        public String Edad { get; set; }    
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Correo { get; set; }
        public String Direccion { get; set; }
        public String Barrio { get; set; }
        public String Tipo_Vivienda { get; set; }
        public string Sectores_Completados { get; set; }

        public Persona(string documento,string nombre,string apellido, string sexo,string edad, string telefono, DateTime fechaNacimiento, string correo, string direccion, string barrio, string tipo_Vivienda, string sectores_completados)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            Direccion = direccion;
            Barrio = barrio;
            Tipo_Vivienda = tipo_Vivienda;
            Sectores_Completados = sectores_completados;            
        }
        public override string ToString()
        {
            return $"{Documento};{Nombre};{Apellido};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()};{Correo};{Direccion};{Barrio};{Tipo_Vivienda};{Sectores_Completados}";
        }
    }
}
