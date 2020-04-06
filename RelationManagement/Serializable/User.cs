using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement
{
    [Serializable]
    public class User
    {
        int Id;
        string Type;
        DateTime CreationDate;
        string UserName;
        string Password;
    }
}
