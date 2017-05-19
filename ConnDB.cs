using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Exceptions
{
    public class ConnDB
    {
        public static MySqlConnection DBConnection()
        {
            String connString = "Server=localhost; Database=c1608l ; Port=3306; User ID = root;Password = ";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            return conn;
        }
    }
}
