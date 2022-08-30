using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Expense
    {
        public Expense(string expenseName, ExpenseType expenseType, double amount, DateTime date, string location)
        {
            ExpenseName = expenseName;
            ExpenseType = expenseType;
            Amount = amount;
            Date = date;
            Location = location;
        }
        public string ExpenseName { get; set; }
        public DateTime Date { get { return DateTime.Now; } set { Date = value; } }
        public ExpenseType ExpenseType { get; set; }
        public double Amount { get; set; }
        public string Location { get; set; }
    }
}
