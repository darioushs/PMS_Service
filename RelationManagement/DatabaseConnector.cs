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
        private SeniorProject DatabaseInstance;
        public static DatabaseConnector databaseConnectorSingleton = new DatabaseConnector();

        public DatabaseConnector()
        {
            //Connect(); We are not using this method of connecting to the database
            CreateDatabaseInstance();
        }

        public int Connect()
        {
            try
            {
                Connect("senior-project.cvmprfnml7ye.us-east-2.rds.amazonaws.com", 3306, "standard-user", "KennesawState!!", "SeniorProject");
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

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

        private void CreateDatabaseInstance()
        {
            DatabaseInstance = new SeniorProject();
        }


        public SeniorProject GetDatabaseInstance()
        {
            return DatabaseInstance;
        }
    }
}
