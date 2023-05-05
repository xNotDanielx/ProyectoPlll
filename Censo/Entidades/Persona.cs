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
        public String Sexo { get; set; }
        public String Edad { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Persona() { }

        public Persona(string nombre, string sexo, string edad, string telefono, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
        }
        public override string ToString()
        {
            return $"{Nombre};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()}";
        }
    }
}
