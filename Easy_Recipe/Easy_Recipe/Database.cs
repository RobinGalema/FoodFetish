using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Easy_Recipe
{
    class DatabaseConnection
    {
        public static SqlConnection conn = null;

        public void Connection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
        }
    }
}
