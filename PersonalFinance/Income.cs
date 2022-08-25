using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Income
    {
        private IncomeType incomeType;
        private string incomeName;
        private double amount;

        public Income(IncomeType incomeType, string incomeName, double amount)
        {
            this.incomeType = incomeType;
            this.incomeName = incomeName;
            this.amount = amount;
        }
        public IncomeType IncomeType { get { return incomeType; } }
        public string IncomeName { get { return incomeName; } }
        public double Amount { get { return amount; } }
    }
}
