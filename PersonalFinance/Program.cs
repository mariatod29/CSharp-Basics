using System;
using System.Diagnostics;
using System.Xml.Linq;
using PersonalFinance;

namespace PersonalFinance
{
    public class Program
    {
        static void Main(string[] args)
        {

            ExpenseType expenseType1 = new ExpenseType("Vorsorgungsrechnungen");
            DateTime expenseDate1 = new DateTime(11/08/2022);
            List<Expense> expenseList = new List<Expense>()
            {
                new Expense { ExpenseName = "Strom", ExpenseType = expenseType1, Amount = 100, Date = expenseDate1, Location = "EON" },
                new Expense { ExpenseName = "Wasser", ExpenseType = expenseType1, Amount = 150, Date = expenseDate1, Location = "ViK" },
                new Expense { ExpenseName = "Internet", ExpenseType = expenseType1, Amount = 50, Date = expenseDate1, Location = "Vivaslon" }
            };
        }

        public string GetExpensesInfo()
        {
            return string.Format("Expense name: {0}, expense type: {1}, amount: ${2}, date: {3}, Location: {4}");
        }
    }
}