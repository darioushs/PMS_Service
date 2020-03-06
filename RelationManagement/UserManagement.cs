using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserManagement" in both code and config file together.
    public class UserManagement : IUserManagement
    {
        DatabaseConnector Connector = new DatabaseConnector();
        
        public int Login(string username, string password)
        {
            
            try
            {
                Connector.Connect("senior-project.cvmprfnml7ye.us-east-2.rds.amazonaws.com", 3306, "standard-user", "KennesawState!!", "SeniorProject");
                return 1;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
