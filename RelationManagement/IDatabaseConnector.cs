using System.ServiceModel;

namespace RelationManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDatabaseConnector" in both code and config file together.
    [ServiceContract]
    public interface IDatabaseConnector
    {
        [OperationContract]
        string hi(string name);
    }
}
