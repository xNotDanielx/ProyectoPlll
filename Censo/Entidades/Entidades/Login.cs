using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        public Login() { }      
        public String Numero_Documento { get; set; }
        public String Contraseña { get; set; }
        public String Tipo_Documento { get; set; }
        public int Cuentas_Registradas { get; set; }

        public Login(string numero_Documento, string contraseña, string tipo_Documento,int cuentas_registradas)
        {
            Numero_Documento = numero_Documento;
            Contraseña = contraseña;
            Tipo_Documento = tipo_Documento;
            Cuentas_Registradas = cuentas_registradas;
        }

        public override string ToString()
        {
            return $"{Numero_Documento};{Contraseña};{Tipo_Documento};";
        }
    }
}
