using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class Income
    {
        public Income(IncomeType incomeType, string incomeName, double amount)
        {
            IncomeType = incomeType;
            IncomeName = incomeName;
            Amount = amount;
        }
        public IncomeType IncomeType { get { return IncomeType; } set { IncomeType = value; } }
        public string IncomeName { get { return IncomeName; } set { IncomeName = value; } }
        public double Amount { get { return Amount; } set { Amount = value; } }
    }
}
