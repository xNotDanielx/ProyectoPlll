using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        String rutaPersona = "Personas.txt";
        String rutaLogin = "Login.txt";
        String Ruta_sectorE = "Resultados(Sector Economico)_Censo.txt";
        String Ruta_sectorH = "Resultados(Sector Hogar)_Censo.txt";
        String Ruta_sectorS = "Resultados(Sector Social)_Censo.txt";

        public String Guardar_Persona(Persona persona)
        {
            StreamWriter sw = new StreamWriter(rutaPersona, true);
            sw.WriteLine(persona.ToString());
            sw.Close();
            return "se guardo Correctamente... ";
        }

        public String Guardar_Login(Login login)
        {
            StreamWriter sw = new StreamWriter(rutaLogin, true);
            sw.WriteLine(login.ToString());
            sw.Close();
            return "se guardo Correctamente... ";
        }

        public String GuardarSector_Economico(Sector_Economico sectorE)
        {
            StreamWriter sw = new StreamWriter(Ruta_sectorE, true);
            sw.WriteLine(sectorE.ToString());
            sw.Close();
            return "se guardo Correctamente...";
        }

        public String GuardarSector_Hogar(Sector_Hogar sectorH)
        {
            StreamWriter sw = new StreamWriter(Ruta_sectorH, true);
            sw.WriteLine(sectorH.ToString());
            sw.Close();
            return "se guardo Correctamente...";
        }

        public String GuardarSector_Social(Sector_Social sectorS)
        {
            StreamWriter sw = new StreamWriter(Ruta_sectorS, true);
            sw.WriteLine(sectorS.ToString());
            sw.Close();
            return "se guardo Correctamente...";
        }

        public Persona MapeadorPersona(String linea)
        {
            var persona = new Persona();
            string[] aux = linea.Split(';');
            persona.Nombre = aux[0];
            persona.Documento = aux[1];
            persona.Sexo = aux[2];
            persona.Edad = aux[3];
            persona.Telefono = aux[4];
            persona.FechaNacimiento = DateTime.Parse(aux[5]);
            persona.Correo = aux[6];
            persona.Estrato = int.Parse(aux[7]);
            persona.Sectores_Completados = bool.Parse(aux[8]);
            return persona;
        }
        public Login MapeadorLogin(string linea)
        {
            var login = new Login();
            string[] aux = linea.Split(';');
            login.Tipo_Documento = aux[0];
            login.Numero_Documento = aux[1];
            login.Contraseña = aux[2];
            return login;
        }

        public Sector_Economico Mapeador_SE(string linea)
        {
            var options = new Sector_Economico();
            string[] aux = linea.Split(';');
            options.Empleado = int.Parse(aux[0]);
            options.Propietario_Negocio = int.Parse(aux[1]);
            options.Trabajador_Privado = int.Parse(aux[2]);
            options.Contratista_Independiente = int.Parse(aux[3]);
            options.Pensionado = int.Parse(aux[4]);
            options.Subsidiado = int.Parse(aux[5]);
            options.Accionistas = int.Parse(aux[6]);
            options.Trabajador_Publico = int.Parse(aux[7]);
            options.Ingreso_Actividades = int.Parse(aux[8]);
            options.Desempleado = int.Parse(aux[9]);
            return options;
        }

        public Sector_Hogar Mapeador_SH(string linea)
        {
            var options = new Sector_Hogar();
            string[] aux = linea.Split(';');
            options.Zona = aux[0];
            options.Propietario = int.Parse(aux[1]);
            options.Servicio_Agua = int.Parse(aux[2]);
            options.Servicio_Luz = int.Parse(aux[3]);
            options.Servicio_Gas = int.Parse(aux[4]);
            options.Saneamiento = int.Parse(aux[5]);
            options.Adicional = int.Parse(aux[6]);
            options.Habitaciones = int.Parse(aux[7]);
            options.Baños = int.Parse(aux[8]);
            options.Tipo_Vivienda = aux[9];
            options.Ingreso = aux[10];
            options.Internet = int.Parse(aux[11]);
            options.Cable = int.Parse(aux[12]);
            options.Telefono = int.Parse(aux[13]);
            options.Vehiculo = int.Parse(aux[14]);
            
            return options;
        }

        public Sector_Social Mapeador_SS(string linea)
        {
            var options = new Sector_Social();
            string[] aux = linea.Split(';');
            options.Afliado = int.Parse(aux[0]);
            options.Victima_Conflicto = int.Parse(aux[1]);
            options.Etnia = aux[2];
            options.Acceso_Estudio = int.Parse(aux[3]);
            options.Servicio_Transporte = int.Parse(aux[4]);
            options.Estado_Civil = aux[5];
            options.NivelEducacion = aux[6];
            return options;
        }

        public List<Persona> consultarPersona()
        {
            var lista = new List<Persona>();
            try
            {
                var sr = new StreamReader(rutaPersona);
                while (!sr.EndOfStream)
                {
                    lista.Add(MapeadorPersona(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }
        public List<Login> consultarCuenta()
        {
            var lista = new List<Login>();
            try
            {
                var sr = new StreamReader(rutaLogin);
                while (!sr.EndOfStream)
                {
                    lista.Add(MapeadorLogin(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Sector_Economico> consultarSE()
        {
            var lista = new List<Sector_Economico>();
            try
            {
                var sr = new StreamReader(Ruta_sectorE);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapeador_SE(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Sector_Hogar> consultarSH()
        {
            var lista = new List<Sector_Hogar>();
            try
            {
                var sr = new StreamReader(Ruta_sectorH);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapeador_SH(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Sector_Social> consultarSS()
        {
            var lista = new List<Sector_Social>();
            try
            {
                var sr = new StreamReader(Ruta_sectorS);
                while (!sr.EndOfStream)
                {
                    lista.Add(Mapeador_SS(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public string Actualizar_Persona(List<Persona> listaActualizada)
        {
            string rutaTemp = "Temp.txt";
            try
            {
                StreamWriter sr = new StreamWriter(rutaTemp, true);
                foreach (var item in listaActualizada)
                {
                    sr.WriteLine(item.ToString());
                }
                sr.Close();

                File.Delete(rutaPersona);
                File.Move(rutaTemp, rutaPersona);
                return "Contacto eliminado...";
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }

        public string Actualizar_Cuenta(List<Login> listaActualizada)
        {
            string rutaTemp = "Temp.txt";
            try
            {
                StreamWriter sr = new StreamWriter(rutaTemp, true);
                foreach (var item in listaActualizada)
                {
                    sr.WriteLine(item.ToString());
                }
                sr.Close();

                File.Delete(rutaLogin);
                File.Move(rutaTemp, rutaLogin);
                return "Contacto eliminado...";
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }

        public string Actualizar_SectorSE(List<Persona> listaActualizada)
        {
            string rutaTemp = "Temp.txt";
            try
            {
                StreamWriter sr = new StreamWriter(rutaTemp, true);
                foreach (var item in listaActualizada)
                {
                    sr.WriteLine(item.ToString());
                }
                sr.Close();

                File.Delete(Ruta_sectorE);
                File.Move(rutaTemp, Ruta_sectorE);
                return "Contacto eliminado...";
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }

        public string Actualizar_SectorSH(List<Persona> listaActualizada)
        {
            string rutaTemp = "Temp.txt";
            try
            {
                StreamWriter sr = new StreamWriter(rutaTemp, true);
                foreach (var item in listaActualizada)
                {
                    sr.WriteLine(item.ToString());
                }
                sr.Close();

                File.Delete(Ruta_sectorH);
                File.Move(rutaTemp, Ruta_sectorH);
                return "Contacto eliminado...";
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }

        public string Actualizar_SectorSS(List<Persona> listaActualizada)
        {
            string rutaTemp = "Temp.txt";
            try
            {
                StreamWriter sr = new StreamWriter(rutaTemp, true);
                foreach (var item in listaActualizada)
                {
                    sr.WriteLine(item.ToString());
                }
                sr.Close();

                File.Delete(Ruta_sectorS);
                File.Move(rutaTemp, Ruta_sectorS);
                return "Contacto eliminado...";
            }
            catch (Exception)
            {
                return "Error al eliminar";
            }
        }
    }
}
