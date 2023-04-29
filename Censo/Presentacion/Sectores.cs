using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Sectores
    {
        Persona persona = new Persona();
        public bool Completado = false;
        public int Sector = 0;
        public void VerMenuSectorEconomico()
        {
            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR CONOMICO");
            //AQUI METERAS LAS PREGUMTAS DEL CENSO
            Completado = true;           
            Sector = 1; //SI COMPLETO EN CENSO 1 SI NO EN TONCES NO PUEDE ENTRAR AL SIGUIENTE CENSO
            persona.Completado = Completado;
            persona.Sector = Sector;
        }
        public void VerMenuSectorSocial()
        {      
            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR SOCIAL");
            //AQUI METERAS LAS PREGUMTAS DEL CENSO
            Sector = 2; //SI COMPLETO EN CENSO 2  
            persona.Sector = Sector;
            //AL FINAL CUANDO COMPLETE CADA CENSO METE TODO ESOS RESULTADOS A ARCHIVOS.. AQUI MISMO SI QUIERES O CREANDO UN PUBLIC VOID GUARDAR RESULTADOS
            // CADA CENSO TIENE SU ARCHIVO
        }
        public void VerMenuSectorHogar()
        {
            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR HOGAR");
            //AQUI METERAS LAS PREGUMTAS DEL CENSO
            Sector = 3; //SI COMPLETO EN CENSO 3 
            persona.Sector = Sector;
        }
        public void Sectores_Completados()
        {    
            Console.SetCursorPosition(40, 9); Console.WriteLine("FELICIDADES!!!");
            Console.SetCursorPosition(40, 10); Console.WriteLine("SECTORES COMPLETADOS");
            Thread.Sleep(2000);
        }
       
    }
}
