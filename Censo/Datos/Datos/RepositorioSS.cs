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
    public class RepositorioSS : Conexion
    {
        public RepositorioSS(string connectionString) : base(connectionString)
        {
        }

        public List<Sector_Social> GetAll()
        {
            List<Sector_Social> SS = new List<Sector_Social>();
            var comando = sqlcon.CreateCommand();
            comando.CommandText = "select * from SectorSocial";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                SS.Add(Mapeador_SS(lector));
            }
            Close();
            return SS;
        }

        private Sector_Social Mapeador_SS(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Sector_Social  SS = new Sector_Social();
            SS.Documento = dataReader.GetString(0);
            SS.Afliado = dataReader.GetInt32(1);
            SS.Victima_Conflicto = dataReader.GetInt32(2);
            SS.Etnia = dataReader.GetString(3);
            SS.Acceso_Estudio = dataReader.GetInt32(4);
            SS.Servicio_Transporte = dataReader.GetInt32(5);
            SS.Estado_Civil = dataReader.GetString(6);
            SS.NivelEducacion = dataReader.GetString(7);
        


            return SS;

        }


        public void Insert(Sector_Social SS)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into SectorSocial (Documento,Afliado,Victima_Conflicto,Etnia,Acceso_Estudio,Servicio_Transporte," +
                "Estado_Civil, NivelEducacion) Values (@Documento,@Afliado,@Victima_Conflicto,@Etnia,@Acceso_Estudio,@Servicio_Transporte," +
                "@Estado_Civil,@NivelEducacion);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SS.Documento;
                Comando.Parameters.Add("Afliado", SqlDbType.Int).Value = SS.Afliado;
                Comando.Parameters.Add("Victima_Conflicto", SqlDbType.Int).Value = SS.Victima_Conflicto;
                Comando.Parameters.Add("Etnia", SqlDbType.VarChar).Value = SS.Etnia;
                Comando.Parameters.Add("Acceso_Estudio", SqlDbType.Int).Value = SS.Acceso_Estudio;
                Comando.Parameters.Add("Servicio_Transporte", SqlDbType.Int).Value = SS.Servicio_Transporte;
                Comando.Parameters.Add("Estado_Civil", SqlDbType.VarChar).Value = SS.Estado_Civil;
                Comando.Parameters.Add("NivelEducacion", SqlDbType.VarChar).Value = SS.NivelEducacion;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void InsertDoc(string Doc)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into SectorSocial (Documento) values (@Documento);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = Doc;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Update(Sector_Social SS)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update SectorSocial SET Documento = @Documento,Afliado = @Afliado,Victima_Conflicto = @Victima_Conflicto," +
                    "Etnia = @Etnia,Acceso_Estudio = @Acceso_Estudio,Servicio_Transporte = @Servicio_Transporte," +
                    "Estado_Civil = @Estado_Civil,NivelEducacion = @NivelEducacion " +
                    "where Documento = @Documento;";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SS.Documento;
                Comando.Parameters.Add("Afliado", SqlDbType.Int).Value = SS.Afliado;
                Comando.Parameters.Add("Victima_Conflicto", SqlDbType.Int).Value = SS.Victima_Conflicto;
                Comando.Parameters.Add("Etnia", SqlDbType.VarChar).Value = SS.Etnia;
                Comando.Parameters.Add("Acceso_Estudio", SqlDbType.Int).Value = SS.Acceso_Estudio;
                Comando.Parameters.Add("Servicio_Transporte", SqlDbType.Int).Value = SS.Servicio_Transporte;
                Comando.Parameters.Add("Estado_Civil", SqlDbType.VarChar).Value = SS.Estado_Civil;
                Comando.Parameters.Add("NivelEducacion", SqlDbType.VarChar).Value = SS.NivelEducacion;

                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Delete(Sector_Social SS)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Delete FROM SectorSocial WHERE Documento = @Documento;";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SS.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

    }
}
