using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conexion
    {
        protected SqlConnection sqlcon;

        public Conexion(string connectionString)
        {
            sqlcon = new SqlConnection(connectionString);
        }

        public void Open()
        {            
            sqlcon.Open();
        }            

        public void Close()
        {
            sqlcon.Close();
        }
    }
}
