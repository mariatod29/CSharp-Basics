using System;
using AdapterDesignPattern;

namespace AdapterDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] employees = new string[5, 4]
            {
                {"101", "John", "SE", "10000" },
                {"102", "Smith", "SE", "20000" },
                {"103", "Devon", "SSE", "30000" },
                {"104", "Pamela", "SE", "40000" },
                {"105", "Sara", "SSE", "50000" }
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employees);

            Console.Read();
        }
    }
}