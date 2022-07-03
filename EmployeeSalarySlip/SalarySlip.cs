using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySlip
{
    abstract class SalarySlip
    {
        public string employeeType;
        public int basicSalary;
        public int fuelAllowance;
        public int medicalAllowance;

        public string SalaryCount()
        {

                Console.WriteLine("The basic salary for "+ employeeType + " is: " + basicSalary);
                Console.WriteLine("The Fuel Allowance for " + employeeType + " is: " + fuelAllowance);
                Console.WriteLine("The Medical Allowance for " + employeeType + " is:" + medicalAllowance);
                Console.Write("The Gross Salary for " + employeeType + " is: ");
                Console.WriteLine(basicSalary + fuelAllowance + medicalAllowance);
                Console.WriteLine("");
                return employeeType;
            
        }
    }


}
