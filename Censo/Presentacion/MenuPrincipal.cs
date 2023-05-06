using Entidades;
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
        presentacionGUI mostrar = new presentacionGUI();
        SectoresGUI sector = new SectoresGUI();
        public void VerMenuPrincipal(Persona login)
        {
            int op;
            do
            {

                Console.Clear();
                Console.SetCursorPosition(40, 8); Console.WriteLine( " _________________________________________");
                Console.SetCursorPosition(40, 9); Console.WriteLine( "|  ***********menú principal***********   |");
                Console.SetCursorPosition(40, 10); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 11); Console.WriteLine("|  1 - Ver mi informacion                 |");
                Console.SetCursorPosition(40, 12); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 13); Console.WriteLine("|  2 - Completar Censo                    |");
                Console.SetCursorPosition(40, 14); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 15); Console.WriteLine("|  0 - Salir                              |");
                Console.SetCursorPosition(40, 16); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(40, 17); Console.WriteLine("|  Que quieres hacer:                     |");
                Console.SetCursorPosition(40, 18); Console.WriteLine("|_________________________________________|");
                Console.SetCursorPosition(62, 17); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        loginGUI.Munu_Login();
                        break;
                    case 1:
                        mostrar.MostrarInformacion(login);
                        break;
                    case 2:
                        sector.VerMenuSectorEconomico();
                        break;                    

                }
            } while (op != 0);
        }
        int op;      
    }
}

