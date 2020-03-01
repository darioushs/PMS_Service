using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DatabaseConnector" in both code and config file together.
    public class DatabaseConnector : IDatabaseConnector
    {
        public string hi(string name)
        {
            return "hi" + name;
        }
    }
}
