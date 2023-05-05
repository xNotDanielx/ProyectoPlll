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
        ServicioSE logicaSE = new ServicioSE();
        ServicioSH logicaSH = new ServicioSH();
        ServicioSS logicaSS = new ServicioSS();
        public  void VerMenuSectorEconomico()
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
            if (Respuesta() == true)
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
            VerMenuSectorSocial(SE);
        }

        int opcion = 0;
        public void VerMenuSectorSocial(Sector_Economico SE)
        {
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
            opcion = 0;
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
            opcion = 0;
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
            opcion = 0;
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
            VerMenuSectorHogar(SE, SS);
        }
        public void VerMenuSectorHogar(Sector_Economico SE, Sector_Social SS)
        {
            Console.Clear();
            Console.SetCursorPosition(40, 9); Console.WriteLine("CENSO SECTOR HOGAR");
            Console.SetCursorPosition(27, 7); Console.WriteLine("Favor NO salir de la app durante la encuesta");
            Thread.Sleep(4000);
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Vive en una zona urbana o rural?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Urbana");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Rural");
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                SH.Zona = "Urbana";                   
            }
            else if (opcion == 2)
            {
                SH.Zona = "Rural";
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Es propietario/a de la vivienda en la que reside actualmente?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Propietario = 1;
            }
            else
            {
                SH.Propietario = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuenta con servicio de Agua?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Servicio_Agua = 1;
            }
            else
            {
                SH.Servicio_Agua = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuenta con servicio de Luz?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Servicio_Luz = 1;
            }
            else
            {
                SH.Servicio_Luz = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuenta con servicio de Gas?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Servicio_Gas = 1;
            }
            else
            {
                SH.Servicio_Gas = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tienes acceso a saneamiento adecuado en tu hogar (por ejemplo, inodoro, sistema de alcantarillado)?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Saneamiento = 1;
            }
            else
            {
                SH.Saneamiento = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tienes propiedades adicionales, como segundas viviendas o terrenos?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Adicional = 1;
            }
            else
            {
                SH.Adicional = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuántas habitaciones tiene tu vivienda?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3");
            Console.SetCursorPosition(40, 10); Console.WriteLine("4");
            Console.SetCursorPosition(40, 11); Console.WriteLine("5");
            Console.SetCursorPosition(40, 12); Console.WriteLine("6 o más");
            SH.Habitaciones = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Cuántos baños completos tiene tu vivienda?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3");
            Console.SetCursorPosition(40, 10); Console.WriteLine("4 o más");
            SH.Baños = int.Parse(Console.ReadKey().ToString());
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tu vivienda es de propiedad o alquilada?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Propia");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Alquilada");
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                SH.Tipo_Vivienda = "Urbana";
            }
            else if (opcion == 2)
            {
                SH.Tipo_Vivienda = "Rural";
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿Tu vivienda es de propiedad o alquilada?");
            Console.SetCursorPosition(40, 7); Console.WriteLine("1-Bajo");
            Console.SetCursorPosition(40, 8); Console.WriteLine("2-Medio");
            Console.SetCursorPosition(40, 9); Console.WriteLine("3-Alto");
            opcion = int.Parse(Console.ReadKey().ToString());
            if (opcion == 1)
            {
                SH.Ingreso = "Bajo";
            }
            else if (opcion == 2)
            {
                SH.Tipo_Vivienda = "Medio";
            }
            else if (opcion == 3)
            {
                SH.Tipo_Vivienda = "Alto";
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿El hogar cuenta con acceso a internet?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Internet = 1;
            }
            else
            {
                SH.Internet = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿El hogar cuenta con acceso a televisión por cable o satelital?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Cable = 1;
            }
            else
            {
                SH.Cable = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿El hogar cuenta con teléfono fijo?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Telefono = 1;
            }
            else
            {
                SH.Telefono = 0;
            }
            Console.Clear();
            Console.SetCursorPosition(40, 6); Console.WriteLine("¿El hogar cuenta con vehículo propio?");
            Respuesta();
            if (Respuesta() == true)
            {
                SH.Vehiculo = 1;
            }
            else
            {
                SH.Vehiculo = 0;
            }
            logicaSE.Añadir(SE);
            logicaSS.Añadir(SS);
            logicaSH.Añadir(SH);
            Sectores_Completados();
        }
        public void Sectores_Completados()
        {           
            Console.SetCursorPosition(40, 9); Console.WriteLine("FELICIDADES!!!");
            Console.SetCursorPosition(40, 10); Console.WriteLine("SECTORES COMPLETADOS");
            Thread.Sleep(3000);
            
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
