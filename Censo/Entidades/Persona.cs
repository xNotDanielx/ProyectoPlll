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
<<<<<<< HEAD
        public Persona() { }

        public Persona(string nombre, string sexo, string edad, string telefono, DateTime fechaNacimiento)
=======
        public String Correo { get; set; }
        public int Sector { get; set; }
        public bool Completado { get; set; }
        public bool Sectores_Completados { get; set; }
        public Persona() { }

        public Persona(string nombre, string tipo_documento, string numero_documento, string contraseña, string sexo, string edad, string telefono, DateTime fechaNacimiento, string correo,int sector,bool completado, bool sectores_completados)
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        {
            Nombre = nombre;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
<<<<<<< HEAD
=======
            Correo = correo;
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        }
        public override string ToString()
        {
            return $"{Nombre};{Sexo};{Edad};{Telefono};{FechaNacimiento.ToShortDateString()}";
        }
    }
}
