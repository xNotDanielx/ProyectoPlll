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
        String ruta = "Personas.txt";
        String ruta_Resultados = "Resultados_Censo.txt";

        public String guardar_Cuentas(Persona persona)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(persona.ToString());
            sw.Close();
            return "se guardo Correctamente... ";
        }

        public String guardar_Resultados(Persona persona)
        {
            StreamWriter sw = new StreamWriter(ruta_Resultados, true);
            sw.WriteLine(persona.ToString());
            sw.Close();
            return "se guardo Correctamente...";
        }

        public Persona Mapeador(String linea)
        {
            var persona = new Persona();
            string[] aux = linea.Split(';');
            persona.Nombre = aux[0];
            persona.Tipo_Documento = aux[1];
            persona.Numero_Documento = aux[2];
            persona.Contraseña = aux[3];
            persona.Sexo = aux[4];
            persona.Edad = aux[5];
            persona.Telefono = aux[6];
            persona.FechaNacimiento = DateTime.Parse(aux[7]);
            persona.Correo = aux[8];
            return persona;
        }

        public List<Persona> consultar()
        {
            var lista = new List<Persona>();
            try
            {
                var sr = new StreamReader(ruta);
                //var linea = string.Empty;
                while (!sr.EndOfStream)
                {
                    //  linea = sr.ReadLine();
                    lista.Add(Mapeador(sr.ReadLine()));
                }
                sr.Close();
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }
    }
}
