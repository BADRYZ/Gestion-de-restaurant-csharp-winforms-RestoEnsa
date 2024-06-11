using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoEnsa
{
    internal class DbManager
    {


        static string server = "localhost";
        static string uid = "root";
        static string password = "";
        static string database = "restoensa";



        private MySqlConnection connection;

        public DbManager()
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;


            try
            {
                connection = new MySqlConnection(conString);
                Console.WriteLine("Connection established.");
            }
            catch (Exception e)
            {
                //e.printStackTrace();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void closeConnection()
        {
            if (connection != null)
            {
                try
                {
                    //connection.close();
                }
                catch (Exception e)
                {
                    //    e.printStackTrace();
                }
            }
        }
    }
}
