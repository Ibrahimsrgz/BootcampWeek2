using SolidApp.Models;

namespace SolidApp
{
    public interface IWorkerManager
    {

        List<FullTimeEmployee> GetFullTimeEmployees();
        List<ContractEmployee> GetContractEmployees();
    }
}
