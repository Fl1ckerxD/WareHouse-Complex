using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Warehouse_Complex
{
    class MySqlConnect
    {
        public SqlConnection sqlConnection = null;
        public void Connect()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            sqlConnection.Open();
        }
    }
}
