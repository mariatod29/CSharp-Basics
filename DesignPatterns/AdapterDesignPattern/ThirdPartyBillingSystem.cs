using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
