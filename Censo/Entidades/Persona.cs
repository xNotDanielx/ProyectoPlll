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
        public String CC { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Correo { get; set; }
        public int Estrato { get; set; }
        public String Etnia { get; set; }

        public Persona()
        {
            
        }

        public Persona(String nombre, String cc, char sexo, int edad, String telefono, DateTime fechanacimiento, String correo, int estrato, String etnia)
        {
            Nombre = nombre;
            CC = cc;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechanacimiento;                
            Correo = correo;
            Estrato = estrato;
            Etnia = etnia;
        }

        public override string ToString()
        {
            return $"{Nombre};{CC};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()};{Correo};{Estrato};{Etnia}";
        }
    }
}
