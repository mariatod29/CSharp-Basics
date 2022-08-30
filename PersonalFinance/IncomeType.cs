using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance
{
    public class IncomeType
    {

        public string Name
        {
            get { return Name; }
            set
            {
                if (Name == null)
                {
                    throw new ArgumentException("The input is invalid.");
                }
                else
                {
                    Name = value;
                }
            }
        }
    }
}
