using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CustomerOrganizer.Database
{
    class Connections
    {
        public class db
        {
            public static MySqlConnection connection { get; set; }
            public static string server { get; set; }
            public static string database { get; set; }
            public static string user { get; set; }
            public static string password { get; set; }
            public static string port { get; set; }
            public static string connectionString { get; set; }
            public static string sslM { get; set; }
            public static string conString { get; set; }
            public static bool connected { get; set; }
            public static bool tryConnect()
            {
                server = "localhost";
                database = "vdevsonl_customer_organizer";
                user = "root";
                password = "";
                port = "3306";
                sslM = "none";
                connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4};", server, port, user, password, database, sslM);
                conString = connectionString;
                connection = new MySqlConnection(conString);
                try
                {
                    connection.Open();
                    return true;
                }catch(MySqlException sqlException)
                {
                    return false;
                }
            }
        }
    }
}
