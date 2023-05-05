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
        ServicioLogin serviciologin = new ServicioLogin();
        Persona persona = new Persona();
<<<<<<< HEAD
        Login login = new Login();  
=======
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
        public void Munu_Login()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(45, 8); Console.WriteLine( " _________________________________ ");
                Console.SetCursorPosition(45, 9); Console.WriteLine( "|  ***********LOGIN***********    |");
                Console.SetCursorPosition(45, 10); Console.WriteLine("|_________________________________|");
                Console.SetCursorPosition(45, 11); Console.WriteLine("|  1 - Inciar Sesion              |");
                Console.SetCursorPosition(45, 12); Console.WriteLine("|_________________________________|");
                Console.SetCursorPosition(45, 13); Console.WriteLine("|  2 - Registrarse                |");
                Console.SetCursorPosition(45, 14); Console.WriteLine("|_________________________________|");
                Console.SetCursorPosition(45, 15); Console.WriteLine("|  0 - Salir                      |");
                Console.SetCursorPosition(45, 16); Console.WriteLine("|_________________________________|");
                Console.SetCursorPosition(45, 17); Console.WriteLine("|  Que quieres hacer:             |");
                Console.SetCursorPosition(45, 18); Console.WriteLine("|_________________________________|");
                Console.SetCursorPosition(66, 17); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Inciar_Sesion();
                        break;
                    case 2:
                        Registrarse();
                        break;
                    default:
                        Console.Clear();
                        Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________ ");
                        Console.SetCursorPosition(45, 9); Console.WriteLine( "|             MENSAJE ERROR            |");
                        Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________|");
                        Console.SetCursorPosition(45, 11); Console.WriteLine("| Por favor elija una opcion valida   |");
                        Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________|");
                        Thread.Sleep(2000);
                        break;
                        

                }
            } while (op != 0);
            
        }
        public void Capturar_Datos()
        {
            int dia=0, mes=0, año=0;
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Nombre: ");
            Console.SetCursorPosition(58, 6); persona.Nombre = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite el Sexo al que pertenece: ");
            Console.SetCursorPosition(73, 6); persona.Sexo = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Edad: ");
            Console.SetCursorPosition(56, 6); persona.Edad = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Telefono: ");
            Console.SetCursorPosition(60, 6); persona.Telefono = Console.ReadLine();
            Console.Clear();
<<<<<<< HEAD
=======
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su correo electronico (Opcional): ");
            Console.SetCursorPosition(81, 6); persona.Correo = Console.ReadLine();
            if (persona.Correo == "")
            {
                persona.Correo = "Sin informacion";
            }
            Console.Clear();
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Fecha de nacimiento DIA: ");
            Console.SetCursorPosition(75, 6); dia = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Fecha de nacimiento MES: ");
            Console.SetCursorPosition(75, 6); mes = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("Digite su Fecha de nacimiento AÑO: ");
            Console.SetCursorPosition(75, 6); año = int.Parse(Console.ReadLine());
            persona.FechaNacimiento = new DateTime(año, mes, dia);
            serviciopersonas.Añadir_Persona(persona);
<<<<<<< HEAD
            serviciologin.Añadir_Cuentas(login);             
=======
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2

        }
        public void Inciar_Sesion()
        {         
            var menu = new MenuPrincipal();
            string Documento_Verificar;
            string Contraseña_Verificar;
            Console.Clear();
            Console.SetCursorPosition(45, 8); Console.WriteLine( " ______________________________________________ ");
            Console.SetCursorPosition(45, 9); Console.WriteLine( "|               INICIO DE SESION               |");
            Console.SetCursorPosition(45, 10); Console.WriteLine("|______________________________________________|");
            Console.SetCursorPosition(45, 11); Console.WriteLine("| NUMERO DE DOCUMENTO:                         |");
            Console.SetCursorPosition(45, 12); Console.WriteLine("|______________________________________________|");
            Console.SetCursorPosition(45, 13); Console.WriteLine("| CONTRASEÑA:                                  |");
            Console.SetCursorPosition(45, 14); Console.WriteLine("|______________________________________________|");
<<<<<<< HEAD
            Console.SetCursorPosition(67, 11); login.Numero_Documento = Console.ReadLine();
            Console.SetCursorPosition(58, 13); login.Contraseña = Console.ReadLine();      
            if (serviciologin.Buscar_Cuenta(login) == true)
=======
            Console.SetCursorPosition(67, 11); persona.Numero_Documento = Console.ReadLine();
            Console.SetCursorPosition(58, 13); persona.Contraseña = Console.ReadLine();      
            if (serviciopersonas.Buscar_Cuenta(persona) == true)
>>>>>>> 29767ac7c29f43332e1128ecc0f20913c0ac4cf2
            {
                Console.Clear();
                 Console.SetCursorPosition(45, 11); Console.WriteLine("Iniciando Sesion... ");
                 Thread.Sleep(2000);
                 menu.VerMenuPrincipal();
            }
            else
            {
                Console.Clear();
                Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________________________________ ");
                Console.SetCursorPosition(45, 9); Console.WriteLine( "|                        MENSJE ERROR                         |");
                Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________________|");
                Console.SetCursorPosition(45, 11); Console.WriteLine("| CC o Contraseña incorrecta, por favor intente nuevamente    |");
                Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________________|");
                Thread.Sleep(2000);
                Inciar_Sesion();
                
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
                Console.SetCursorPosition(45, 8); Console.WriteLine( " ______________________________________________ ");
                Console.SetCursorPosition(45, 9); Console.WriteLine( "|                   REGISTRO                   |");
                Console.SetCursorPosition(45, 10); Console.WriteLine("|______________________________________________|");
                Console.SetCursorPosition(45, 11); Console.WriteLine("|                TIPO DE DOCUMENTO             |");
                Console.SetCursorPosition(45, 12); Console.WriteLine("| 1) CEDULA CIUDADANA                          |");
                Console.SetCursorPosition(45, 13); Console.WriteLine("| 2) TARJETA DE IDENTIDAD                      |");
                Console.SetCursorPosition(45, 14); Console.WriteLine("| -                                            |");
                Console.SetCursorPosition(45, 15); Console.WriteLine("|______________________________________________|");
                Console.SetCursorPosition(48, 14); Tipo_documento = Console.ReadLine();
            
                if (Tipo_documento == "1")
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 8); Console.WriteLine (" ______________________________________________ ");
                    Console.SetCursorPosition(45, 9); Console.WriteLine( "|                   REGISTRO                   |");
                    Console.SetCursorPosition(45, 10); Console.WriteLine("|______________________________________________|");
                    Console.SetCursorPosition(45, 11); Console.WriteLine("| NUMERO DE DOCUMENTO:                         |");
                    Console.SetCursorPosition(45, 12); Console.WriteLine("|______________________________________________|");
                    Console.SetCursorPosition(45, 13); Console.WriteLine("| CONTRASEÑA:                                  |");
                    Console.SetCursorPosition(45, 14); Console.WriteLine("|______________________________________________|");
                    Console.SetCursorPosition(67, 11); Documento_verificar = Console.ReadLine();
                    Verificar_Numeros = int.TryParse(Documento_verificar, out num);
                    if (Documento_verificar.Length <= 1 || Documento_verificar.Length >= 11)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________________________________ ");
                        Console.SetCursorPosition(45, 9); Console.WriteLine( "|                        MENSJE ERROR                         |");
                        Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________________|");
                        Console.SetCursorPosition(45, 11); Console.WriteLine("| La cantidad de numeros del documento no es valida           |");
                        Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________________|");
                        Thread.Sleep(2000);
                        Verificado_documento = "No Verificado";
                    }
                    else if (Verificar_Numeros = false)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________________________________ ");
                        Console.SetCursorPosition(45, 9); Console.WriteLine( "|                        MENSJE ERROR                         |");
                        Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________________|");
                        Console.SetCursorPosition(45, 11); Console.WriteLine("| El numero de documento no puede tener Letras o Simbolos     |");
                        Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________________|");
                        Thread.Sleep(3000);
                        Verificado_documento = "No Verificado";
                    }
                    else
                    {
                        login.Tipo_Documento = "CC";
                        login.Numero_Documento = Documento_verificar;
                        Verificado_documento = "Verificado";
                    }
                }
                else if (Tipo_documento == "2")
                {
                        Console.Clear();
                        Console.SetCursorPosition(45, 8); Console.WriteLine( " ______________________________________________ ");
                        Console.SetCursorPosition(45, 9); Console.WriteLine( "|                   REGISTRO                   |");
                        Console.SetCursorPosition(45, 10); Console.WriteLine("|______________________________________________|");
                        Console.SetCursorPosition(45, 11); Console.WriteLine("| NUMERO DE DOCUMENTO:                         |");
                        Console.SetCursorPosition(45, 12); Console.WriteLine("|______________________________________________|");
                        Console.SetCursorPosition(45, 13); Console.WriteLine("| CONTRASEÑA:                                  |");
                        Console.SetCursorPosition(45, 14); Console.WriteLine("|______________________________________________|");
                        Console.SetCursorPosition(67, 11); Documento_verificar = Console.ReadLine();
                        Verificar_Numeros = int.TryParse(Documento_verificar, out num);
                        if (Documento_verificar.Length <= 6 || Documento_verificar.Length >= 11)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 8); Console.WriteLine(" _____________________________________________________________ ");
                            Console.SetCursorPosition(45, 9); Console.WriteLine(" |                        MENSJE ERROR                         |");
                            Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________________|");
                            Console.SetCursorPosition(45, 11); Console.WriteLine("| La cantidad de numeros del documento no es valida           |");
                            Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________________|");
                            Thread.Sleep(2000);
                            Verificado_documento = "No Verificado";
                        }
                        else if (Verificar_Numeros = false)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 8); Console.WriteLine(" _____________________________________________________________ ");
                            Console.SetCursorPosition(45, 9); Console.WriteLine("|                        MENSJE ERROR                         |");
                            Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________________|");
                            Console.SetCursorPosition(45, 11); Console.WriteLine("| El numero de documento no puede tener Letras o Simbolos     |");
                            Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________________|");
                            Thread.Sleep(2000);
                            Verificado_documento = "No Verificado";
                        }
                        else
                        {
                            login.Tipo_Documento = "TI";
                            login.Numero_Documento = Documento_verificar;
                            Verificado_documento = "Verificado";
                        }                  
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 8); Console.WriteLine( " _______________________________________________________________________");
                    Console.SetCursorPosition(45, 9); Console.WriteLine( "|                              MENSJE ERROR                             |");
                    Console.SetCursorPosition(45, 10); Console.WriteLine("|_______________________________________________________________________|");
                    Console.SetCursorPosition(45, 11); Console.WriteLine("| Elija un documento valido (TarJeta de Identidad Ó Cedula Ciudadana)    |");
                    Console.SetCursorPosition(45, 12); Console.WriteLine("|_______________________________________________________________________|");
                    Thread.Sleep(2000);
                    Verificado_documento = "No Verificado";
                }
            } while(Verificado_documento != "Verificado");

            string Verificado_Contraseña = "";
            do
            {
                string Contraseña_Verificar;
                Console.SetCursorPosition(58, 13); Contraseña_Verificar = Console.ReadLine();
                if (Contraseña_Verificar == "")
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________________________");
                    Console.SetCursorPosition(45, 9); Console.WriteLine( "|                    MENSJE ERROR                     |");
                    Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________|");
                    Console.SetCursorPosition(45, 11); Console.WriteLine("| Casilla Vacia, por favor digite una contraseña      |");
                    Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________|");
                    Thread.Sleep(2000);
                    Verificado_Contraseña = "No Verificado";
                }
                else if(Contraseña_Verificar.Length <=8)
                {
                    Console.Clear();
                    Console.SetCursorPosition(45, 8); Console.WriteLine( " _____________________________________________________");
                    Console.SetCursorPosition(45, 9); Console.WriteLine( "|                     MENSJE ERROR                    |");
                    Console.SetCursorPosition(45, 10); Console.WriteLine("|_____________________________________________________|");
                    Console.SetCursorPosition(45, 11); Console.WriteLine("| La contraseña debe tener al menos 8 caracteres      |");
                    Console.SetCursorPosition(45, 12); Console.WriteLine("|_____________________________________________________|");
                    Verificado_Contraseña = "No Verificado";
                }
                else
                {
                    login.Contraseña = Contraseña_Verificar;
                    Capturar_Datos();
                    Verificado_Contraseña = "Verificado";
                }
            }while (Verificado_Contraseña != "Verificado");
                
        }
    }
}
