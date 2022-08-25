using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class ExpenseType
    {

        public string Name 
        { 
            get{ return this.Name; } 
            set 
            { 
                if (this.Name == null)
                {
                    throw new ArgumentException("The input is invalid.");
                }
                else
                {
                    this.Name = value;
                }
            } 
        }
    }
}
