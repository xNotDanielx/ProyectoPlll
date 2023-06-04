using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPersona : Conexion
    {
        public RepositorioPersona(string connectionString) : base(connectionString)
        {
        }

        public List<Persona> GetAll()
        {
            List<Persona> Personas = new List<Persona>();
            var comando = sqlcon.CreateCommand();
            comando.CommandText = "select * from Persona";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Personas.Add(Mapeador_Persona(lector));
            }
            Close();
            return Personas;
        }

        private Persona Mapeador_Persona(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Persona Persona = new Persona();
            Persona.Documento = dataReader.GetString(0);
            Persona.Nombre = dataReader.GetString(1);
            Persona.Apellido = dataReader.GetString(2);
            Persona.Sexo = dataReader.GetString(3);
            Persona.Edad = dataReader.GetString(4);
            Persona.Telefono = dataReader.GetString(5);
            Persona.FechaNacimiento = dataReader.GetDateTime(6);
            Persona.Correo = dataReader.GetString(7);
            Persona.Direccion = dataReader.GetString(8);
            Persona.Barrio = dataReader.GetString(9);
            Persona.Tipo_Vivienda = dataReader.GetString(10);
            Persona.Sectores_Completados = dataReader.GetString(11);

            return Persona;

        }


        public void Insert(Persona persona)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Persona (Documento,Nombre,Apellido,Sexo,Edad,Telefono," +
                "FechaNacimiento,Correo,Direccion,Barrio,Tipo_Vivienda,Sectores_Completados)" +
                " values (@Documento,@Nombre,@Apellido,@Sexo,@Edad,@Telefono,@FechaNacimiento," +
                "@Correo,@Direccion,@Barrio,@Tipo_Vivienda,@Sectores_Completados);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = persona.Documento;
                Comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = persona.Nombre;
                Comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = persona.Apellido;
                Comando.Parameters.Add("Sexo", SqlDbType.VarChar).Value = persona.Sexo;
                Comando.Parameters.Add("Edad", SqlDbType.VarChar).Value = persona.Edad;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = persona.Telefono;
                Comando.Parameters.Add("FechaNacimiento", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                Comando.Parameters.Add("Correo", SqlDbType.VarChar).Value = persona.Correo;
                Comando.Parameters.Add("Direccion", SqlDbType.VarChar).Value = persona.Direccion;
                Comando.Parameters.Add("Barrio", SqlDbType.VarChar).Value = persona.Barrio;
                Comando.Parameters.Add("Tipo_Vivienda", SqlDbType.VarChar).Value = persona.Tipo_Vivienda;
                Comando.Parameters.Add("Sectores_Completados", SqlDbType.VarChar).Value = persona.Sectores_Completados;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Update(Persona persona)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update Persona SET Nombre = @Nombre, " +
                    "Apellido = @Apellido,Sexo = @Sexo,Edad = @Edad, Telefono = @Telefono" +
                    "FechaNacimiento = @FechaNacimiento, Correo = @Correo,Direccion = @Direccion" +
                    "Barrio = @Barrio,Tipo_Vivienda = @Tipo_Vivienda,Sectores_Completados = @Sectores_Completados" +
                    "WHERE Documento = @Documento;";
                Comando.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = persona.Nombre;
                Comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = persona.Apellido;
                Comando.Parameters.Add("Sexo", SqlDbType.VarChar).Value = persona.Sexo;
                Comando.Parameters.Add("Edad", SqlDbType.VarChar).Value = persona.Edad;
                Comando.Parameters.Add("Telefono", SqlDbType.VarChar).Value = persona.Telefono;
                Comando.Parameters.Add("FechaNacimiento", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                Comando.Parameters.Add("Correo", SqlDbType.VarChar).Value = persona.Correo;
                Comando.Parameters.Add("Direccion", SqlDbType.VarChar).Value = persona.Direccion;
                Comando.Parameters.Add("Barrio", SqlDbType.VarChar).Value = persona.Barrio;
                Comando.Parameters.Add("Tipo_Vivienda", SqlDbType.VarChar).Value = persona.Tipo_Vivienda;
                Comando.Parameters.Add("Sectores_Completados", SqlDbType.VarChar).Value = persona.Sectores_Completados;
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = persona.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void UpdateSectorComplete(string Sector, String Doc)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update Persona SET Sectores_Completados = @Sectores_Completados " +
                    "WHERE Documento = @Documento;";
                Comando.Parameters.Add("Sectores_Completados", SqlDbType.VarChar).Value = Sector;
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = Doc;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Delete(Persona persona)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Delete FROM Persona WHERE Documento = @Documento;";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = persona.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
    }
}
