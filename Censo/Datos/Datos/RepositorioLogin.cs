using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using Entidades;
using System.Data;
using System.Runtime.InteropServices;

namespace Datos
{
    public class RepositorioLogin : Conexion
    {
        public RepositorioLogin(string connectionString) : base(connectionString)
        {            
        }

        public List<Login> GetAll()
        {
            List<Login> login = new List<Login>();
            var comando = sqlcon.CreateCommand();
            comando.CommandText = "SELECT * FROM Loguin";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                login.Add(Mapeador_Login(lector));
            }
            Close();
            return login;
        }

        public DataTable GetBy(String Columna, String DocumentoBuscar)
        {
            Open();
            SqlCommand comando = sqlcon.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select * from Loguin where " + Columna + " like ('" + DocumentoBuscar + "%')";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comando);
            dataAdapter.Fill(dt);
            Close();
            return dt;
        }

        private Login Mapeador_Login(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Login personaLog = new Login();
            personaLog.Admin = dataReader.GetBoolean(0);
            personaLog.Numero_Documento = dataReader.GetString(1);
            personaLog.Contraseña = dataReader.GetString(2);
            personaLog.Tipo_Documento = dataReader.GetString(3);

            return personaLog;
        }


        public void Insert(Login personaLog)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Loguin (Admin,Numero_Documento,Contraseña,Tipo_Documento)" +
                " values (@Admin,@Numero_Documento,@Contraseña,@Tipo_Documento);";
                Comando.Parameters.Add("Admin", SqlDbType.Bit).Value = false;
                Comando.Parameters.Add("Numero_Documento", SqlDbType.VarChar).Value = personaLog.Numero_Documento;
                Comando.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = personaLog.Contraseña;
                Comando.Parameters.Add("Tipo_Documento", SqlDbType.VarChar).Value = personaLog.Tipo_Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Update(Login PersonaLog)
        {
            using(var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update Loguin SET Admin = @Admin, Contraseña = @Contraseña, " +
                    "Tipo_Documento = @Tipo_Documento " +
                    "WHERE Numero_Documento = @Numero_Documento;";
                Comando.Parameters.Add("Admin", SqlDbType.Bit).Value = PersonaLog.Admin;
                Comando.Parameters.Add("Contraseña", SqlDbType.VarChar).Value = PersonaLog.Contraseña;
                Comando.Parameters.Add("Tipo_Documento", SqlDbType.VarChar).Value = PersonaLog.Tipo_Documento;
                Comando.Parameters.Add("Numero_Documento", SqlDbType.VarChar).Value = PersonaLog.Numero_Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Delete(Login PersonaLog)
        {
            using(var Comando =  sqlcon.CreateCommand())
            {
                Comando.CommandText = "Delete FROM Loguin WHERE Numero_Documento = @Numero_Documento;";
                Comando.Parameters.Add("Numero_Documento", SqlDbType.VarChar).Value = PersonaLog.Numero_Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

    }
}