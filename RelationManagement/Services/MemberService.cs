using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement.Services
{
    class MemberService
    {
        public void MemberSelect(int memberID,int projectID)
        {
            SeniorProject db = new SeniorProject();
            var select = from o in db.Member
                         where o.ID == memberID && o.ProjectID == projectID
                         select o;

        }

        public void ContractDelete(int memberID)
        {

        }

        public void ContractUpdate()
        {

        }
    }
}
