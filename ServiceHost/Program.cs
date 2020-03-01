using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ProgramServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(RelationManagement.DatabaseConnector)))
            {
                host.Open();
                Console.WriteLine("hoste started");
                Console.ReadLine();
            }
        }
    }
}
