using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class SectoresGUI
    {
        Sector_Economico SE = new Sector_Economico();
        Sector_Social SS = new Sector_Social();
        Sector_Hogar SH = new Sector_Hogar();
        ServicioPersona logica = new ServicioPersona();
        public bool Completado = false;
        public Sector_Economico VerMenuSectorEconomico()
        {
            Console.SetCursorPosition(40, 6); Console.WriteLine("SECTOR ECONOMICO");
            Console.SetCursorPosition(27, 7); Console.WriteLine("Favor NO salir de la app durante la encuesta");
            Console.SetCursorPosition(40, 7); Console.WriteLine("             [1(SI)/2(NO)]");
            Thread.Sleep(5000);
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tiene empleo remunerado actualmente?");            
            SE.Empleado = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es usted propietario de un negocio?");
            SE.Propietario_Negocio = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe ingresos por alquileres de bienes raíces?");
            SE.Trabajador_Privado = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Trabaja como Trabajador Independiente?");
            SE.Contratista_Independiente = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es trabajador Público?");
            SE.Trabajador_Publico = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es pensionado o jubilado y recibe ingresos por ello?");
            SE.Pensionado = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe algún tipo de subsidio o asistencia social?");
            SE.Subsidiado = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha obtenido ingresos de inversiones financieras en el último año?");
            SE.Accionistas= int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe ingresos por actividades agrícolas, ganaderas o pesqueras?");
            SE.Ingreso_Actividades = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha tenido algún tipo de desempleo o inactividad económica en el último año?");
            SE.Desempleado = int.Parse(Console.ReadKey().ToString());
            VerMenuSectorSocial();
            return SE;
        }
        int opcion = 0;
        public Sector_Social VerMenuSectorSocial()
        {
            Console.Clear();
            Console.SetCursorPosition(40, 9); Console.WriteLine("SECTOR SOCIAL");
            Console.SetCursorPosition(27, 7); Console.WriteLine("Favor NO salir de la app durante la encuesta");
            Console.SetCursorPosition(40, 7); Console.WriteLine("             [1(SI)/2(NO)]");
            Thread.Sleep(5000);
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Está afiliado/a a algún programa de seguridad social, como seguro médico o jubilación?");
            SS.Afliado = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha sido víctima de algún tipo de discriminación o violencia basada en su género, raza, religión, orientación sexual, discapacidad o cualquier otra característica protegida?");
            SS.Victima_Conflicto = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Pertenece a alguno de estos grupos etnicos?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Arhuaco");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Kogui");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3-Kankuamo");
            Console.SetCursorPosition(40, 10); Console.WriteLine("4-WiWa");
            Console.SetCursorPosition(40, 11); Console.WriteLine("5-Yucpa");
            Console.SetCursorPosition(40, 12); Console.WriteLine("6-Chimila");
            Console.SetCursorPosition(40, 12+1); Console.WriteLine("0-Ninguno");
            opcion = int.Parse(Console.ReadKey().ToString());
            if(opcion == 1)
            {
                SS.Etnia = "Arhuaco";
            }else if(opcion == 2)
            {
                SS.Etnia = "Kogui";
            }else if(opcion == 3)
            {
                SS.Etnia = "Kankuamo";
            }else if( opcion == 4)
            {
                SS.Etnia = "Wiwa";
            }else if(opcion == 5)
            {
                SS.Etnia = "Yucpa";
            }else if(opcion == 6)
            {
                SS.Etnia = "Chimila";
            }else if(opcion == 0)
            {
                SS.Etnia = "Ninguno";
            }else if(opcion < 0 &&  opcion > 6) 
            {
                SS.Etnia = "Ninguno";
            }
            opcion = 0;               
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tiene acceso a servicios educativos, como escuelas, universidades o programas de capacitación?");
            SS.Acceso_Estudio = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tiene acceso a servicios de transporte público o privado en su área local?");
            SS.Servicio_Transporte = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuál es su estado civil actual?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Soltero");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Casado");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3-Divorciado");
            Console.SetCursorPosition(40, 10); Console.WriteLine("4-viudo");             
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                SS.Estado_Civil = "Soltero";
            }
            else if (opcion == 2)
            {
                SS.Estado_Civil = "Casado";
            }
            else if (opcion == 3)
            {
                SS.Estado_Civil = "Divorciado";
            }
            else if (opcion == 4)
            {
                SS.Estado_Civil = "viudo";
            }
            else if (opcion < 0 && opcion > 4)
            {
                SS.Estado_Civil = "otro";
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuál es su nivel educativo más alto alcanzado?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Sin educacion Formal");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Educacion Primaria");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3-Educación secundaria");
            Console.SetCursorPosition(40, 10); Console.WriteLine("4-Educación técnica o vocacional");
            Console.SetCursorPosition(40, 11); Console.WriteLine("5-Educación universitaria");
            Console.SetCursorPosition(40, 12); Console.WriteLine("6-Otro");
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                SS.Etnia = "No tiene";
            }
            else if (opcion == 2)
            {
                SS.Etnia = "Primaria";
            }
            else if (opcion == 3)
            {
                SS.Etnia = "Secundaria";
            }
            else if (opcion == 4)
            {
                SS.Etnia = "Tecnica";
            }
            else if (opcion == 5)
            {
                SS.Etnia = "Universitaria";
            }
            else if (opcion == 6)
            {
                SS.Etnia = "Otro";
            }

            else if (opcion < 1 && opcion > 6)
            {
                SS.Etnia = "Otro";
            }
            VerMenuSectorHogar();
            return SS;
        }
        public Sector_Hogar VerMenuSectorHogar()
        {

            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR HOGAR");
            //AQUI METERAS LAS PREGUMTAS DEL CENSO
            return SH;
        }
        public void Sectores_Completados()
        {
            Sector_Economico sector_Economico = new Sector_Economico();
            Sector_Social sector_Social = new Sector_Social();
            Sector_Hogar sector_Hogar = new Sector_Hogar();
            sector_Economico = VerMenuSectorEconomico();
            sector_Social = VerMenuSectorSocial();
            sector_Hogar = VerMenuSectorHogar();
            logica.Añadir_Sectores(sector_Economico, sector_Social, sector_Hogar);
            Console.SetCursorPosition(40, 9); Console.WriteLine("FELICIDADES!!!");
            Console.SetCursorPosition(40, 10); Console.WriteLine("SECTORES COMPLETADOS");
            Thread.Sleep(2000);
            
        }
       
    }
}
