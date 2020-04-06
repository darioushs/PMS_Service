using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserManagement" in both code and config file together.
    public class UserManagement : DBConnected, IUserManagement
    {
        DatabaseConnector Connector = new DatabaseConnector();

        public string getAll()
        {
            throw new NotImplementedException();
        }

        public int Login(string username, string password)
        {
            var query = from user in DBInstance.User
                        select user;

            Console.WriteLine(query);
            return 1;
        }
    }
}
