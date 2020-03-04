using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPMS_API" in both code and config file together.
    [ServiceContract]
    public interface IPMS_API
    {
        [OperationContract] string Login(string username, string password);
        [OperationContract] string Logout(string key);
    }
}
