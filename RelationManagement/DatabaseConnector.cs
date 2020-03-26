using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DatabaseConnector" in both code and config file together.
    public class DatabaseConnector
    {
        private MySqlConnection Connection;

        public void Connect(string hostname, int port, string root, string password, string database)
        {
            //using (var context = new SeniorProject()) {
            //    var res = from u in context.User
            //        }
            string conn = "Server=" + hostname + ";user=" + root + ";database=" + database + ";port=" + port + ";password=" + password;
            SeniorProject sp = new SeniorProject();
            Console.WriteLine(conn);
            try
            {
                Connection = new MySqlConnection(conn);
                Connection.Open();
                Console.WriteLine("Connected...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
