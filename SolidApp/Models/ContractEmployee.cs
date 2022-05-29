using SolidApp.Interfaces;

namespace SolidApp.Models
{
    public class ContractEmployee : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
