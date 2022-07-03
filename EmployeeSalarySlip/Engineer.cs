using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySlip
{
    class Engineer : SalarySlip
    {
        public Engineer()
        {
            employeeType = "Engineer";
            basicSalary = 1500;
            fuelAllowance = 100;
            medicalAllowance = 500;
        }
    }
}
