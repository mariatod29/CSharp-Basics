using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook_Chapter22
{
    public static class SubstringStringBuilderClass
    {

        public static void Main()
        {
            string input = "Some Text To Try The Substring Extension Method";
            StringBuilder finalinput = new StringBuilder(input);
            Console.WriteLine(finalinput.Substring(0, 10).ToString());
            Console.WriteLine(finalinput.Substring(3, 10).ToString());
        }
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.ToString().Length; i++)
            {
                if (i >= index && i < length)
                    result.Append(input[i]);
            }
            return result;
        }
    }
}
