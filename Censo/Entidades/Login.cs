using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public String Numero_Documento { get; set; }
        public String Contraseña { get; set; }
        public String Tipo_Documento { get; set; }
        public String Correo { get; set; }

        public Login() { }

        public Login(string numero_Documento, string contraseña, string tipo_Documento, string correo)
        {
            Numero_Documento = numero_Documento;
            Contraseña = contraseña;
            Tipo_Documento = tipo_Documento;
            Correo = correo;
        }

        public override string ToString()
        {
            return $"{Numero_Documento};{Contraseña};{Tipo_Documento};{Correo}";
        }
    }
}
