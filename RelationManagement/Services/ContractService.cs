using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement.Services
{
    class ContractService
    {
        public void ContractSelect(int inputID)
        {
            SeniorProject db = new SeniorProject();
            var select = from o in db.Contract
                                 where o.ID == inputID
                                 select o;
                                
        }

        public void ContractDelete(int inputID)
        {
            SeniorProject db = new SeniorProject();
            var delete = db.Contract.Single(contract => contract.ID == inputID)
                db.Contract.RemoveContractRow();
            

        }

        public void ContractInsert(int inputID, string contractName, string contractDescription, DateTime )
        
        public void ContractUpdate()
        {

        }
    }
}
