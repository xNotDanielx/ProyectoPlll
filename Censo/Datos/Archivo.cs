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

        public String guardar(Persona persona)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(persona.ToString());
            sw.Close();
            return "se guardo... waos";
        }

        public Persona Mapeador(String linea)
        {
            var persona = new Persona();
            string[] aux = linea.Split(';');
            persona.Nombre = aux[0];
            persona.CC = aux[1];
            persona.Sexo = Char.Parse(aux[2]);
            persona.Edad = int.Parse(aux[3]);
            persona.Telefono = aux[4];
            persona.FechaNacimiento = DateTime.Parse(aux[5]);
            persona.Correo = aux[6];
            persona.Estrato = int.Parse(aux[7]);
            persona.Etnia = aux[8];
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
