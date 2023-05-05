using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class presentacionGUI
    {
        Login loguin = new Login();
        ServicioPersona persona = new ServicioPersona();
        public void MostrarInformacion(Login login)
        {
            foreach (var item in persona.GetAll())
            {
                if (login.Numero_Documento == item.Documento)
                {
                    Console.SetCursorPosition(34, 3); Console.WriteLine("____________________________________________________");
                    Console.SetCursorPosition(34, 4); Console.WriteLine("| Nombre: " + item.Nombre);
                    Console.SetCursorPosition(34, 5); Console.WriteLine("|Documento: " + item.Documento);
                    Console.SetCursorPosition(34, 6); Console.WriteLine("|Sexo: " + item.Sexo);
                    Console.SetCursorPosition(34, 7); Console.WriteLine("|Edad: " + item.Edad);
                    Console.SetCursorPosition(34, 8); Console.WriteLine("|Telefono: " + item.Telefono);
                    Console.SetCursorPosition(34, 9); Console.WriteLine("|fecha: " + item.FechaNacimiento);
                    Console.SetCursorPosition(34, 10);Console.WriteLine("|Correo: " + item.Correo);
                    Console.SetCursorPosition(34, 10);Console.WriteLine("|___________________________________________________");
                }
            }
        }
    }
}
