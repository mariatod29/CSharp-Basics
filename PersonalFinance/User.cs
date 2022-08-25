using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class User
    {

        public string Name { get { return Name; } set { Name = value; } }
        public string Password 
        { 
            get { return Password; } 
            set 
            { 
                if ((Password.Length < 8 || Password.Length > 14) && !Password.Any(char.IsUpper) && !Password.Any(char.IsLower))
                {
                    throw new ArgumentOutOfRangeException("The password must be 8-14 characters with at least one upper and one lower case.");
                }
                Password = value; 
            } 
        }
        public List<Expense> Expenses { get { return Expenses; } set { Expenses = value; } }
        public List<ExpenseType> ExpenseTypes { get { return ExpenseTypes; } set { ExpenseTypes = value; } }
        public List<Income> Incomes { get { return Incomes; } set { Incomes = value; } }
        public List<IncomeType> IncomeTypes { get { return IncomeTypes; } set { IncomeTypes = value; } }
    }
}
