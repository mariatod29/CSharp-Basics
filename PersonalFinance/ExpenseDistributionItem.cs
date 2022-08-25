using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseDistributionItem
    {
        public ExpenseDistributionItem(int percentage, ExpenseType expenseType)
        {
            Percentage = percentage;
            ExpenseType = expenseType;
        }
        public int Percentage { get; set; }
        public ExpenseType ExpenseType { get; set; }

        public void CalculateExpenseDistribution()
        {
           
        }
    }
}
