using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook_Chapter22
{
    public class DivisibleBy7And3
    {
        public static void Main()
        {
            int[] arr = new int[7] {21, 49, 42, 3, 7, 33, 63 };
            NumbersWithExtentionMethod(arr);
            NumbersWithLinq(arr);
        }
        public static void NumbersWithExtentionMethod(int[] arr)
        {
            var result = arr.Where(num => (num % 7 == 0 && num % 3 == 0));
            // var result = arr.Where(num => num % 21 == 0);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
        }
        public static void NumbersWithLinq(int[] arr)
        {
            var result = from num in arr
                         where (num % 7 == 0 && num % 3 == 0)
                         select num;
            /* var result = from num in arr
             *              where num % 21 == 0
             *              select num;
             */
            foreach(var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
