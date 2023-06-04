using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class configConnnection
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["CensoConnection"].ConnectionString;
    }
}