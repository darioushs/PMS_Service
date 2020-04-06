using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement
{
    [Serializable]
    public class Contract
    {
        int Id;
        string ContractName;
        string ContractDescription;
        DateTime ContractStart;
        DateTime ContractEnd;
        int ContractApproved;
        string ContractFilePath;
        int ContractSponsorID;
        string ContractType;
    }
}