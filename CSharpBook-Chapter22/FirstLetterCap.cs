using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook_Chapter22
{
    public class FirstLetterCap
    {
       public static void Main()
        {
            string line = Console.ReadLine();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            Console.WriteLine(textInfo.ToTitleCase(line));
        } 
    }
}
