using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement
{
    [Serializable]
    public class Sponsor
    {
        int Id;
        int ProjectId;
        string CompanyName;
        string CompanyPOC;
    }
}