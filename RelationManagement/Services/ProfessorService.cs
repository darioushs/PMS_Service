using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement.Services
{
    class ProfessorService
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

        }

        public void ContractUpdate()
        {

        }
    }
}
