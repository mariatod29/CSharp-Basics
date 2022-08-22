using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employees)
        {
            string Id = null;
            string Name = null;
            string Designation = null;
            string Salary = null;

            List<Employee> employeesList = new List<Employee>();

            for(int i = 0; i < employees.GetLength(0); i++)
            {
                for (int j = 0; j < employees.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employees[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employees[i, j];
                    }
                    else if (j == 2)
                    {
                        Designation = employees[i, j];
                    }
                    else
                    {
                        Salary = employees[i, j];
                    }
                }
                employeesList.Add(new Employee(Convert.ToInt32(Id), Name, Designation, Convert.ToDecimal(Salary)));
            }
            Console.WriteLine("Adapter converted Array of Employee to List of Employee");
            Console.WriteLine("Then delegate to the ThirdPartyBillingSystem for processing the employee salary\n");
            thirdPartyBillingSystem.ProcessSalary(employeesList);
        }
    }
}
