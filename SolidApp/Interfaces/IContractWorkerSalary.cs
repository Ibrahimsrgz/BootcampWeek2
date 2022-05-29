namespace SolidApp.Interfaces
{

    public interface IContractWorkerSalary : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalaculateWorkedSalary();
    }
}
