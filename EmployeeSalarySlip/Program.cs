using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
            SalarySlip engineer = new Engineer();
            SalarySlip manager = new Manager();
            SalarySlip analyst = new Analyst();

            Console.WriteLine("Enter Designation: ");
            string eType = Console.ReadLine();

            if (eType == "Engineer")
            {

                Console.WriteLine(engineer.SalaryCount());
            }

            if (eType == "Manager")
            {

                Console.WriteLine(manager.SalaryCount());
            }

            if (eType == "Analyst")
            {

                Console.WriteLine(analyst.SalaryCount());
            }
            
            
        }
    }
}
