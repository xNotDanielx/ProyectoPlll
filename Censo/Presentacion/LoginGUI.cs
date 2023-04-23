using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using Logica;
using System.Diagnostics.Contracts;
using System.Reflection;

namespace Presentacion
{
    public class LoginGUI
    {
        ServicioPersona serviciopersonas = new ServicioPersona();
        Persona persona = new Persona();
        List<Persona> listpersona;


        public void Munu_Login()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(40, 8); Console.WriteLine("___________________________________________-");
                Console.SetCursorPosition(40, 9); Console.WriteLine("|  ***********LOGIN***********             |");
                Console.SetCursorPosition(40, 10); Console.WriteLine("|  1 - Inciar Sesion                       ");
                Console.SetCursorPosition(40, 11); Console.WriteLine("|  2 - Registrarse                        |");
                Console.SetCursorPosition(40, 12); Console.WriteLine("|  0 - Salir                              |");
                Console.SetCursorPosition(40, 13); Console.WriteLine("|  Que quieres hacer:                     |");
                Console.SetCursorPosition(40, 14); Console.WriteLine("___________________________________________");
                Console.SetCursorPosition(62, 15); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Inciar_Sesion();
                        break;
                    case 2:
                        Registrarse();
                        break;
                }
            } while (op != 0);
            
        }
        public void Capturar_Datos()
        {
            int dia=0, mes=0, año=0;
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Nombre: ");
            persona.Nombre = Console.ReadLine();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite el Sexo al que pertenece: ");
            persona.Sexo = Console.ReadLine();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Edad: ");
            persona.Edad = Console.ReadLine();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Telefono: ");
            persona.Telefono = Console.ReadLine();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su correo electronico (Opcional): ");
            persona.Correo = Console.ReadLine();
            if (persona.Correo == "")
            {
                persona.Correo = "Sin informacion";
            }
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Fecha de nacimiento: DIA: MES: AÑO: ");
            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            año = int.Parse(Console.ReadLine());
            persona.FechaNacimiento = new DateTime(año, mes, dia);
        }
        public void Inciar_Sesion()
        {
            var menu = new MenuPrincipal();
            string Documento_Verificar;
            string Contraseña_Verificar;
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite Numero de Documento: ");
            Documento_Verificar = Console.ReadLine();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite Contraseña: ");
            Contraseña_Verificar = Console.ReadLine();
            foreach(var item in listpersona)
            if (Documento_Verificar.Equals(item.Numero_Documento) & (Contraseña_Verificar.Equals(item.Contraseña)))
                {
                    Console.SetCursorPosition(40, 6); Console.WriteLine("Iniciando Sesion... ");
                    Thread.Sleep(3000);
                    menu.VerMenuPrincipal();
                }
                else
                {
                    Console.SetCursorPosition(40, 6); Console.WriteLine("CC o Contraseña incorrecta, por favor intente nuevamente... ");
                    Thread.Sleep(3000);
                }
        }

        public void Registrarse()
        {
            string Verificado_documento = "";
            string Tipo_documento;
            do
            {               
                string Documento_verificar;              
                bool Verificar_Numeros;
                int num;
                Console.Clear();
                Console.SetCursorPosition(40, 6); Console.WriteLine("Elija el tipo de documento con el que desea regisrarse: ");
                Console.SetCursorPosition(40, 7); Console.WriteLine("1) Cedula Ciudadana ");
                Console.SetCursorPosition(40, 8); Console.WriteLine("2) Targeta de identidad ");
                Tipo_documento = Console.ReadLine();
            
                if (Tipo_documento == "1")
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 6); Console.WriteLine("Digite el numero del documento: ");
                    Documento_verificar = Console.ReadLine();
                    Verificar_Numeros = int.TryParse(Documento_verificar, out num);
                    if (Documento_verificar.Length <= 7 || Documento_verificar.Length >= 10)
                    {
                        Console.SetCursorPosition(40, 6); Console.WriteLine("Numero digitado no valido...");
                        Console.SetCursorPosition(40, 6); Console.WriteLine("La cantidad de numeros del documento no es valida..");
                        Thread.Sleep(3000);
                        Verificado_documento = "No Verificado";
                    }
                    else if (Verificar_Numeros = false)
                    {
                        Console.SetCursorPosition(40, 6); Console.WriteLine("El numero de documento no puede tener Letras o Simbolos..");
                        Thread.Sleep(3000);
                        Verificado_documento = "No Verificado";
                    }
                    else
                    {
                        persona.Tipo_Documento = "CC";
                        persona.Numero_Documento = Documento_verificar;
                        Verificado_documento = "Verificado";
                    }
                }
                else if (Tipo_documento == "2")
                {
                        Console.Clear();
                        Console.SetCursorPosition(40, 6); Console.WriteLine("Digite el numero del documento: ");
                        Documento_verificar = Console.ReadLine();
                        Verificar_Numeros = int.TryParse(Documento_verificar, out num);
                        if (Documento_verificar.Length <= 7 || Documento_verificar.Length >= 10)
                        {
                            Console.SetCursorPosition(40, 6); Console.WriteLine("Numero digitado no valido...");
                            Console.SetCursorPosition(40, 6); Console.WriteLine("La cantidad de numeros del documento no es valida..");
                            Thread.Sleep(3000);
                            Verificado_documento = "No Verificado";
                        }
                        else if (Verificar_Numeros = false)
                        {
                            Console.SetCursorPosition(40, 6); Console.WriteLine("El numero de documento no puede tener Letras o Simbolos..");
                            Thread.Sleep(3000);
                            Verificado_documento = "No Verificado";
                        }
                        else
                        {
                            persona.Tipo_Documento = "TI";
                            persona.Numero_Documento = Documento_verificar;
                            Verificado_documento = "Verificado";
                        }                  
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(40, 6); Console.WriteLine("Elija un documento valido (Targeta de Identidad o Cdula Ciudadana)");
                    Verificado_documento = "No Verificado";
                }
            } while(Verificado_documento != "Verificado");

            string Verificado_Contraseña = "";
            do
            {
                string Contraseña_Verificar;
                Console.SetCursorPosition(40, 6); Console.WriteLine("Digite una costraseña: ");
                Contraseña_Verificar = Console.ReadLine();
                if (Contraseña_Verificar == "")
                {
                    Console.SetCursorPosition(40, 6); Console.WriteLine("Casilla Vacia, por favor digite una contraseña..");
                    Verificado_Contraseña = "No Verificado";
                }
                else if(Contraseña_Verificar.Length <=8)
                {
                    Console.SetCursorPosition(40, 6); Console.WriteLine("La contraseña debe tener al menos 8 caracteres...");
                    Verificado_Contraseña = "No Verificado";
                }
                else
                {
                    persona.Contraseña = Contraseña_Verificar;
                    Verificado_Contraseña = "Verificado";
                }
            }while (Verificado_Contraseña != "Verificado");
                
        }
    }
}
