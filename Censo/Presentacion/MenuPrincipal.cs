using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        ServicioPersona sericiopersona = new ServicioPersona();
        LoginGUI loginGUI = new LoginGUI();
        Sectores sector = new Sectores();
        public void VerMenuPrincipal()
        {
            int op;
            do
            {

                Console.Clear();
                Console.SetCursorPosition(40, 8); Console.WriteLine( " _________________________________________");
                Console.SetCursorPosition(40, 9); Console.WriteLine( "|  ***********menú principal***********   |");
                Console.SetCursorPosition(40, 10); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 11); Console.WriteLine("|  1 - Ver menú sector economico          |");
                Console.SetCursorPosition(40, 12); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 13); Console.WriteLine("|  2 - Ver menú sector social             |");
                Console.SetCursorPosition(40, 14); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 15); Console.WriteLine("|  3 - Ver menú sector Hogar              |");
                Console.SetCursorPosition(40, 16); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 17); Console.WriteLine("|  0 - Salir                              |");
                Console.SetCursorPosition(40, 18); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 19); Console.WriteLine("|  Que quieres hacer:                     |");
                Console.SetCursorPosition(40, 20); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(62, 19); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        loginGUI.Munu_Login();
                        break;
                    case 1:
                        //TIENES QUE HACER QUE LOS RESULTADOS DEL CENSO SE GUARDEN EN ARCHIVOS TODO CON NUMEROS
                        //EMPLEADO=1 (SI DIJO QUE SI = 1), NO EMPLEADO=0(SI DIJO QUE NO = 0), CON CARRO = 1, SIN CARRO= 0.
                        //AL FINAL TODO SE SUMA Y SE SCA EL RESULTADO DEL CENSO EN GENERAL
                        
                        sector.VerMenuSectorEconomico();
                        break;
                    case 2:
                        if (sector.Completado = true & sector.Sector == 2) //COMPRUEBA SI HA COMPLETADO EL CENSO ANTERIOR SI NO ENTONCES NO PUEDE ACCEDER A ESTE CENSO
                        {
                 
                            sector.VerMenuSectorSocial();
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 8); Console.WriteLine( " ___________________________________________________________________________________________________");
                            Console.SetCursorPosition(45, 9); Console.WriteLine( "|                                                AVISO                                              |");
                            Console.SetCursorPosition(45, 10); Console.WriteLine("|___________________________________________________________________________________________________|");
                            Console.SetCursorPosition(45, 11); Console.WriteLine("| Para poder acceder a Ceso (Sector Social), primero debe completar el Cesnso (Sector Ecomico)      |");
                            Console.SetCursorPosition(45, 12); Console.WriteLine("|___________________________________________________________________________________________________|");
                            Thread.Sleep(2000);
                        }                    
                        break;
                    case 3:
                        if (sector.Completado = true & sector.Sector == 3)
                        {
                            sector.VerMenuSectorHogar();
                            //METER CONDICIONAL SI LA PERSONA COMPLETO LOS 3 SECTORES (IF (PERSONA.COMPLETADO=TRUE & PERSONA.SECOTRES==3)
                            //ES POSIBLE QUE LA PERSONA SE SALGA A MITAD DE EL CENSO Y NO COMPLETE NADA
                            sector.Sectores_Completados();
                            VerMenuPrincipal();
                        }
                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(45, 8); Console.WriteLine( " ___________________________________________________________________________________________________");
                            Console.SetCursorPosition(45, 9); Console.WriteLine( "|                                                AVISO                                              |");
                            Console.SetCursorPosition(45, 10); Console.WriteLine("|___________________________________________________________________________________________________|");
                            Console.SetCursorPosition(45, 11); Console.WriteLine("| Para poder acceder a Ceso (Sector Hogar), primero debe completar el Cesnso (Sector Social)        |");
                            Console.SetCursorPosition(45, 12); Console.WriteLine("|___________________________________________________________________________________________________|");
                            Thread.Sleep(2000);
                        }
                       
                        break;

                }
            } while (op != 0);
        }
        int op;      
    }
}

