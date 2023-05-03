using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public String Nombre { get; set; }
        public String Tipo_Documento { get; set; }
        public String Numero_Documento { get; set; }
        public String Contraseña { get;set; }
        public String Sexo { get; set; }
        public String Edad { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Correo { get; set; }
        public int Sector { get; set; }
        public bool Completado { get; set; }
        public bool Sectores_Completados { get; set; }
        public Persona() { }

        public Persona(string nombre, string tipo_documento, string numero_documento, string contraseña, string sexo, string edad, string telefono, DateTime fechaNacimiento, string correo,int sector,bool completado, bool sectores_completados)
        {
            Nombre = nombre;
            Tipo_Documento = tipo_documento;
            Numero_Documento = numero_documento;
            Contraseña = contraseña;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
        }
        public override string ToString()
        {
            return $"{Nombre};{Tipo_Documento};{Numero_Documento};{Contraseña};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()};{Correo};{Sector};{Completado};{Sectores_Completados}";
        }
    }
}
