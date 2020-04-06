using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement
{
    /// <summary>
    /// Every class that needs to connect to the database inherits from this class
    /// </summary>
    public class DBConnected
    {
        protected SeniorProject DBInstance;

        public DBConnected()
        {
            DBInstance = DatabaseConnector.databaseConnectorSingleton.GetDatabaseInstance();
        }
    }
}
