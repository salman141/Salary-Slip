using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySlip
{
    class Analyst : SalarySlip
    {
        public Analyst()
        {
            employeeType = "Analyst";
            basicSalary = 1500;
            fuelAllowance = 150;
            medicalAllowance = 800;
        }
    }
}
