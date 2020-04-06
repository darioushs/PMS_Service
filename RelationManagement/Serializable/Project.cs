using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationManagement
{
    [Serializable]
    public class Project
    {
        int Id;
        string Title;
        int NDA;
        string type;
        int sponsored;
        string Department;
        int PointOfContact;
        string Status;
        DateTime StartDate;
    }
}