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
        public void VerMenuPrincipal()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(40, 8); Console.WriteLine("___________________________________________");
                Console.SetCursorPosition(40, 9); Console.WriteLine("|  ***********menú principal***********   |");
                Console.SetCursorPosition(40, 10); Console.WriteLine("|  1 - Ver menú sector economico          |");
                Console.SetCursorPosition(40, 11); Console.WriteLine("|  2 - Ver menú sector social             |");
                Console.SetCursorPosition(40, 12); Console.WriteLine("|  3 - Ver menú sector territorial        |");
                Console.SetCursorPosition(40, 13); Console.WriteLine("|  0 - Salir                              |");
                Console.SetCursorPosition(40, 14); Console.WriteLine("|  Que quieres hacer:                     |");
                Console.SetCursorPosition(40, 15); Console.WriteLine("___________________________________________");
                Console.SetCursorPosition(62, 14); op = int.Parse(Console.ReadLine());
                switch(op) 
                {
                    case 1:
                        break;
                }
            } while(op!=0);
        }

        public void VerMenuSectorEconomico()
        {
            int op;
            do
            {
                Console.Clear();

                switch (op)
                {

                }
            } while (op != 0);
        }
    }
}
