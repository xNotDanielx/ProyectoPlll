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
        public string Documento { get; set; }
        public String Sexo { get; set; }
        public String Edad { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Correo { get; set; }
        public int Estrato { get; set; }
        public bool Sectores_Completados { get; set; }
        public Persona() { }

        public Persona(string nombre, string documento, string sexo, string edad, string telefono, DateTime fechaNacimiento, string correo, int estrato ,bool sectores_completados)
        {
            Nombre = nombre;
            Documento = documento;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
            Estrato = estrato;
            Sectores_Completados = sectores_completados;
        }
        public override string ToString()
        {
            return $"{Nombre};{Documento};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()};{Correo};{Estrato};{Sectores_Completados}";
        }
    }
}
