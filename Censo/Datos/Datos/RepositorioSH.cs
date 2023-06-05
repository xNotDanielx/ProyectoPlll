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
    public class RepositorioSH : Conexion
    {
        public RepositorioSH(string connectionString) : base(connectionString)
        {
        }

        public List<Sector_Hogar> GetAll()
        {
            List<Sector_Hogar> SH = new List<Sector_Hogar>();
            var comando = sqlcon.CreateCommand();
            comando.CommandText = "select * from Sector_Hogar";
            Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                SH.Add(Mapeador_SH(lector));
            }
            Close();
            return SH;
        }

        private Sector_Hogar Mapeador_SH(SqlDataReader dataReader)
        {

            if (!dataReader.HasRows) return null;
            Sector_Hogar SH = new Sector_Hogar();
            SH.Documento = dataReader.GetString(0);
            SH.Zona = dataReader.GetString(1);
            SH.Propietario = dataReader.GetInt32(2);
            SH.Servicio_Agua = dataReader.GetInt32(3);
            SH.Servicio_Luz = dataReader.GetInt32(4);
            SH.Servicio_Gas = dataReader.GetInt32(5);
            SH.Saneamiento = dataReader.GetInt32(6);
            SH.Adicional = dataReader.GetInt32(7);
            SH.Habitaciones = dataReader.GetString(8);
            SH.Baños = dataReader.GetString(9);
            SH.Tipo_Vivienda = dataReader.GetString(10);
            SH.Ingreso = dataReader.GetString(11);
            SH.Internet = dataReader.GetInt32(12);
            SH.Cable = dataReader.GetInt32(13);
            SH.Telefono = dataReader.GetInt32(14);
            SH.Vehiculo = dataReader.GetInt32(15);
                 


            return SH;

        }


        public void Insert(Sector_Hogar SH)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Sector_Hogar (Documento,Zona,Propietario,Servicio_Agua,Servicio_Luz,Servicio_Gas," +
                "Saneamiento, Adicional,Habitaciones,Baños,Tipo_Vivienda,Ingreso,Internet, Cable, Telefono, Vehiculo)" +
                " values (@Documento,@Zona,@Propietario,@Servicio_Agua,@Servicio_Luz,@Servicio_Gas," +
                "@Saneamiento, @Adicional,@Habitaciones,@Baños,@Tipo_Vivienda,@Ingreso,@Internet, @Cable, @Telefono, @Vehiculo);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SH.Documento;
                Comando.Parameters.Add("Zona", SqlDbType.VarChar).Value = SH.Zona;
                Comando.Parameters.Add("Propietario", SqlDbType.Int).Value = SH.Propietario;
                Comando.Parameters.Add("Servicio_Agua", SqlDbType.Int).Value = SH.Servicio_Agua;
                Comando.Parameters.Add("Servicio_Luz", SqlDbType.Int).Value = SH.Servicio_Luz;
                Comando.Parameters.Add("Servicio_Gas", SqlDbType.Int).Value = SH.Servicio_Gas;
                Comando.Parameters.Add("Saneamiento", SqlDbType.Int).Value = SH.Saneamiento;
                Comando.Parameters.Add("Adicional", SqlDbType.Int).Value = SH.Adicional;
                Comando.Parameters.Add("Habitaciones", SqlDbType.VarChar).Value = SH.Habitaciones;
                Comando.Parameters.Add("Baños", SqlDbType.VarChar).Value = SH.Baños;
                Comando.Parameters.Add("Tipo_Vivienda", SqlDbType.VarChar).Value = SH.Tipo_Vivienda;
                Comando.Parameters.Add("Ingreso", SqlDbType.VarChar).Value = SH.Ingreso;
                Comando.Parameters.Add("Internet", SqlDbType.Int).Value = SH.Internet;
                Comando.Parameters.Add("Cable", SqlDbType.Int).Value = SH.Cable;
                Comando.Parameters.Add("Telefono", SqlDbType.Int).Value = SH.Telefono;
                Comando.Parameters.Add("Vehiculo", SqlDbType.Int).Value = SH.Vehiculo;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void InsertDoc(string Doc)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Insert Into Sector_Hogar (Documento) values (@Documento);";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = Doc;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Update(Sector_Hogar SH)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Update Sector_Hogar SET Documento = @Documento,Zona = @Zona,Propietario = @Propietario," +
                    "Servicio_Agua = @Servicio_Agua,Servicio_Luz = @Servicio_Luz,Servicio_Gas = @Servicio_Gas," +
                    "Saneamiento = @Saneamiento,Adicional = @Adicional,Habitaciones = @Habitaciones,Baños = @Baños," +
                    "Tipo_Vivienda = @Tipo_Vivienda,Ingreso = @Ingreso, Internet = @Internet, Cable = @Cable, Telefono = @Telefono, Vehiculo = @Vehiculo " +
                    "where Documento = @Documento;";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SH.Documento;
                Comando.Parameters.Add("Zona", SqlDbType.VarChar).Value = SH.Zona;
                Comando.Parameters.Add("Propietario", SqlDbType.Int).Value = SH.Propietario;
                Comando.Parameters.Add("Servicio_Agua", SqlDbType.Int).Value = SH.Servicio_Agua;
                Comando.Parameters.Add("Servicio_Luz", SqlDbType.Int).Value = SH.Servicio_Luz;
                Comando.Parameters.Add("Servicio_Gas", SqlDbType.Int).Value = SH.Servicio_Gas;
                Comando.Parameters.Add("Saneamiento", SqlDbType.Int).Value = SH.Saneamiento;
                Comando.Parameters.Add("Adicional", SqlDbType.Int).Value = SH.Adicional;
                Comando.Parameters.Add("Habitaciones", SqlDbType.VarChar).Value = SH.Habitaciones;
                Comando.Parameters.Add("Baños", SqlDbType.VarChar).Value = SH.Baños;
                Comando.Parameters.Add("Tipo_Vivienda", SqlDbType.VarChar).Value = SH.Tipo_Vivienda;
                Comando.Parameters.Add("Ingreso", SqlDbType.VarChar).Value = SH.Ingreso;
                Comando.Parameters.Add("Internet", SqlDbType.Int).Value = SH.Internet;
                Comando.Parameters.Add("Cable", SqlDbType.Int).Value = SH.Cable;
                Comando.Parameters.Add("Telefono", SqlDbType.Int).Value = SH.Telefono;
                Comando.Parameters.Add("Vehiculo", SqlDbType.Int).Value = SH.Vehiculo;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }

        public void Delete(Sector_Hogar SH)
        {
            using (var Comando = sqlcon.CreateCommand())
            {
                Comando.CommandText = "Delete FROM Sector_Hogar WHERE Documento = @Documento;";
                Comando.Parameters.Add("Documento", SqlDbType.VarChar).Value = SH.Documento;
                Open();
                Comando.ExecuteNonQuery();
                Close();
            }
        }
    }
}
