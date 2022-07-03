using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySlip
{
    class Manager : SalarySlip
    {
        public Manager()
        {
            employeeType = "Manager";
            basicSalary = 1500;
            fuelAllowance = 250;
            medicalAllowance = 1000;
        }
    }
}
