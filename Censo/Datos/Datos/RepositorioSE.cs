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
    public class RepositorioSE : Conexion
    {
        public RepositorioSE(string connectionString) : base(connectionString)
        {
        }

        public List<Sector_Economico> GetAll()
        {
            List<Sector_Economico> ListaSE = new List<Sector_Economico>();
            var comando = sqlcon.CreateCommand();
            comando.CommandText = "select * from Sector_Economico";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                ListaSE.Add(Mapeador_SE(lector));
            }
            Close();
            return ListaSE;
        }

        private Sector_Economico Mapeador_SE(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Sector_Economico SE = new Sector_Economico();
            SE.Documento = dataReader.GetString(0);
            SE.Empleado = dataReader.GetInt32(1);
            SE.Propietario_Negocio = dataReader.GetInt32(2);
            SE.Trabajador_Privado = dataReader.GetInt32(3);
            SE.Contratista_Independiente = dataReader.GetInt32(4);
            SE.Pensionado = dataReader.GetInt32(5);
            SE.Subsidiado = dataReader.GetInt32(6);
            SE.Accionistas = dataReader.GetInt32(7);
            SE.Trabajador_Publico = dataReader.GetInt32(8);
            SE.Ingreso_Actividades = dataReader.GetInt32(9);
            SE.Desempleado = dataReader.GetInt32(10);
            SE.Estrato = dataReader.GetString(11);
            return SE;
        }


        public void Insert(Sector_Economico SE)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Sector_Economico (Documento,Empleado,Propietario_Negocio,Trabajador_Privado,Contratista_Independiente,Pensionado," +
                "Subsidiado, Accionistas,Trabajador_Publico,Ingreso_Actividades,Desempleado, Estrato)" +
                " values (@Documento,@Empleado,@Propietario_Negocio,@Trabajador_Privado,@Contratista_Independiente,@Pensionado," +
                "@Subsidiado, @Accionistas,@Trabajador_Publico,@Ingreso_Actividades,@Desempleado, @Estrato);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SE.Documento;
                Comando.Parameters.Add("Empleado", SqlDbType.Int).Value = SE.Empleado;
                Comando.Parameters.Add("Propietario_Negocio", SqlDbType.VarChar).Value = SE.Propietario_Negocio;
                Comando.Parameters.Add("Trabajador_Privado", SqlDbType.Int).Value = SE.Trabajador_Privado;
                Comando.Parameters.Add("Contratista_Independiente", SqlDbType.Int).Value = SE.Contratista_Independiente;
                Comando.Parameters.Add("Pensionado", SqlDbType.Int).Value = SE.Pensionado;
                Comando.Parameters.Add("Subsidiado", SqlDbType.Int).Value = SE.Subsidiado;
                Comando.Parameters.Add("Accionistas", SqlDbType.Int).Value = SE.Accionistas;
                Comando.Parameters.Add("Trabajador_Publico", SqlDbType.Int).Value = SE.Trabajador_Publico;
                Comando.Parameters.Add("Ingreso_Actividades", SqlDbType.Int).Value = SE.Ingreso_Actividades;
                Comando.Parameters.Add("Desempleado", SqlDbType.Int).Value = SE.Desempleado;
                Comando.Parameters.Add("Estrato", SqlDbType.VarChar).Value = SE.Estrato;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void InsertDoc(String Doc)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Sector_Economico (Documento) values (@Documento);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = Doc;                
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Update(Sector_Economico SE)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update Sector_Economico SET Empleado = @Empleado,Propietario_Negocio = @Propietario_Negocio,Trabajador_Privado = @Trabajador_Privado," +
                    "Contratista_Independiente = @Contratista_Independiente,Pensionado = @Pensionado,Subsidiado = @Subsidiado," +
                    "Accionistas = @Accionistas,Trabajador_Publico = @Trabajador_Publico,Ingreso_Actividades = @Ingreso_Actividades," +
                    "Desempleado = @Desempleado,Estrato = @Estrato " +
                    "where Documento = @Documento;";
                Comando.Parameters.Add("Empleado", SqlDbType.Int).Value = SE.Empleado;
                Comando.Parameters.Add("Propietario_Negocio", SqlDbType.Int).Value = SE.Propietario_Negocio;
                Comando.Parameters.Add("Trabajador_Privado", SqlDbType.Int).Value = SE.Trabajador_Privado;
                Comando.Parameters.Add("Contratista_Independiente", SqlDbType.Int).Value = SE.Contratista_Independiente;
                Comando.Parameters.Add("Pensionado", SqlDbType.Int).Value = SE.Pensionado;
                Comando.Parameters.Add("Subsidiado", SqlDbType.Int).Value = SE.Subsidiado;
                Comando.Parameters.Add("Accionistas", SqlDbType.Int).Value = SE.Accionistas;
                Comando.Parameters.Add("Trabajador_Publico", SqlDbType.Int).Value = SE.Trabajador_Publico;
                Comando.Parameters.Add("Ingreso_Actividades", SqlDbType.Int).Value = SE.Ingreso_Actividades;
                Comando.Parameters.Add("Desempleado", SqlDbType.Int).Value = SE.Desempleado;
                Comando.Parameters.Add("Estrato", SqlDbType.VarChar).Value = SE.Estrato;
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SE.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Delete(Sector_Economico SE)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Delete FROM Sector_Economico WHERE Documento = @Documento;";
                Comando.Parameters.Add("Numero_Documento", SqlDbType.VarChar).Value = SE.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
    }
}
