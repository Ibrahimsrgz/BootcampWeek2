using Microsoft.AspNetCore.Mvc;
using SolidApp.Models;

using SolidApp.Interfaces;

using System.Linq;

namespace SolidApp
{
    public class WorkerManager:IWorkerManager
    {

        private readonly List<ContractEmployee> contractEmployees = new List<ContractEmployee>()
        {
            new ContractEmployee
            {
                ID = "1",
                Email=  "ali@gmail.com",
                HourlyRate = 3,
                HoursInMonth=20,
                Name ="Ali"



            },
            new ContractEmployee
            {
                 ID = "2",
                Email=  "veli@gmail.com",
                HourlyRate = 5,
                HoursInMonth=40,
                Name ="Veli"

            },
            new ContractEmployee
            {
                 ID = "3",
                Email=  "ahmet@gmail.com",
                HourlyRate = 5,
                HoursInMonth=50,
                Name ="Ahmet"

            }
        };


        private readonly List<FullTimeEmployee> fullTimeEmployees = new List<FullTimeEmployee>()
        {
            new FullTimeEmployee
            {
                ID = "4",
                Email=  "ayşe@gmail.com",
                Name ="Ayşe",
                MonthlySalary = 5600,
                OtherBenefits=4000
            },
            new FullTimeEmployee
            {
                ID = "5",
                Email=  "fatma@gmail.com",
                Name ="Fatma",
                MonthlySalary = 15600,
                OtherBenefits=44000
            },
            new FullTimeEmployee
            {
                ID = "6",
                Email=  "hatice@gmail.com",
                Name ="Hatice",
                MonthlySalary = 85600,
                OtherBenefits=14000
            },


        };

        public List<ContractEmployee> GetContractEmployees()
        {
            return contractEmployees;

        }

        
        public List<FullTimeEmployee> GetFullTimeEmployees()
        {
            return fullTimeEmployees;

        }


    }
}
