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
        Persona persona = new Persona();
        Sector_Economico SE = new Sector_Economico();
        Sector_Social SS = new Sector_Social();
        Sector_Hogar SH = new Sector_Hogar();
        ServicioPersona logica = new ServicioPersona();
        public bool Completado = false;
        public int Sector = 0;
        public Sector_Economico VerMenuSectorEconomico()
        {

            Console.SetCursorPosition(40, 6); Console.WriteLine("SECTOR ECONOMICO");
            Console.SetCursorPosition(27, 7); Console.WriteLine("Favor NO salir de la app durante la encuesta");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tiene empleo remunerado actualmente?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Empleado = 1;
            }
            else
            {
                SE.Empleado = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es usted propietario de un negocio?");
            Respuesta();
            if (Respuesta()== true)
            {
                SE.Propietario_Negocio = 1;

            }
            else
            {
                SE.Propietario_Negocio = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe ingresos por alquileres de bienes raíces?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Empleado = 1;

            }
            else
            {
                SE.Empleado = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Trabaja como Trabajador Independiente?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Contratista_Independiente = 1;

            }
            else
            {
                SE.Contratista_Independiente = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es trabajador Público?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Trabajador_Publico = 1;

            }
            else
            {
                SE.Trabajador_Publico = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es pensionado o jubilado y recibe ingresos por ello?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Pensionado = 1;

            }
            else
            {
                SE.Pensionado = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe algún tipo de subsidio o asistencia social?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Subsidiado = 1;

            }
            else
            {
                SE.Subsidiado = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha obtenido ingresos de inversiones financieras en el último año?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Accionistas = 1;

            }
            else
            {
                SE.Accionistas = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Recibe ingresos por actividades agrícolas, ganaderas o pesqueras?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Ingreso_Actividades = 1;

            }
            else
            {
                SE.Ingreso_Actividades = 0;
            }
            Console.Clear();       
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha tenido algún tipo de desempleo o inactividad económica en el último año?");
            Respuesta();
            if (Respuesta() == true)
            {
                SE.Desempleado = 1;

            }
            else
            {
                SE.Desempleado = 0;
            }
            SE.Sector_Completado = "Si";
            return SE;
            VerMenuSectorSocial();
        }
        
        public Sector_Social VerMenuSectorSocial()
        {
            int opcion;
            Console.Clear();
            Console.SetCursorPosition(40, 9); Console.WriteLine("SECTOR SOCIAL");
            Console.SetCursorPosition(27, 7); Console.WriteLine("Favor NO salir de la app durante la encuesta");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Está afiliado/a a algún programa de seguridad social, como seguro médico o jubilación?");
            Respuesta();
            if (Respuesta() == true)
            {
                SS.Afliado = 1;

            }
            else
            {
                SS.Afliado = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Ha sido víctima de algún tipo de discriminación o violencia basada en su género, raza, religión, orientación sexual, discapacidad o cualquier otra característica protegida?");
            Respuesta();
            if (Respuesta() == true)
            {
                SS.Victima_Conflicto = 1;

            }
            else
            {
                SS.Victima_Conflicto = 0;
            }
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
            Respuesta();
            if (Respuesta() == true)
            {
                SS.Acceso_Estudio = 1;

            }
            else
            {
                SS.Acceso_Estudio = 0;
            }
           
            Console.Clear();
            opcion = 0;
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tiene acceso a servicios de transporte público o privado en su área local?");
            Respuesta();
            if (Respuesta() == true)
            {
                SS.Servicio_Transporte = 1;

            }
            else
            {
                SS.Servicio_Transporte = 0;
            }
            Console.Clear();
            opcion = 0;
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
                SS.NivelEducacion = "No tiene";
            }
            else if (opcion == 2)
            {
                SS.NivelEducacion = "Primaria";
            }
            else if (opcion == 3)
            {
                SS.NivelEducacion = "Secundaria";
            }
            else if (opcion == 4)
            {
                SS.NivelEducacion = "Tecnica";
            }
            else if (opcion == 5)
            {
                SS.NivelEducacion = "Universitaria";
            }
            else if (opcion == 6)
            {
                SS.NivelEducacion = "Otro";
            }

            else if (opcion < 1 && opcion > 6)
            {
                SS.NivelEducacion = "Otro";
            }
            SS.Sector_Completado = "Si";
            VerMenuSectorHogar();
            return SS;
        }
        public Sector_Hogar VerMenuSectorHogar()
        {
            int opcion = 0;
            Console.Clear();
            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR HOGAR");
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Vive en una zona urbana o rural?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Urbana");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Rural");
            opcion = int.Parse(Console.ReadKey().ToString());     
            if (opcion == 1)
            {
                SH.Urbana = 1;
            }
            else
            {
                SH.Rural = 1;
            }
            //AQUI METERAS LAS PREGUMTAS DEL CENSO
            SH.Sector_Completado = "Si";
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

        public bool Respuesta()
        {
            int opcion = 0;
            Console.SetCursorPosition(40, 7); Console.WriteLine("1- Si");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2- No");
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
