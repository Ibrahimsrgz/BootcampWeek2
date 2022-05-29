using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidApp.Interfaces;
using SolidApp.Models;
using System.Linq;

namespace SolidApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IWorkerManager _workerManager;

        public EmployeeController(IWorkerManager workerManager)
        {
            _workerManager = workerManager;
        }

        

        
      

        [HttpGet("contractemployees")]
        public List<ContractEmployee> GetContractEmployees()
        {
            return _workerManager.GetContractEmployees();

        }

        [HttpGet("fulltimeemployees")]
        public List<FullTimeEmployee> GetFullTimeEmployees()
        {
            return _workerManager.GetFullTimeEmployees();

        }
    }
}
