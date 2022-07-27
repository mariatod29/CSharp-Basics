using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook_Chapter22
{
    public static class ExtentionMethodsIEnumerable
    {
        public static void Main()
        {
            List<double> values = new List<double>() { 6.5, 2.1, 93.1, 45.0, 7.9, 66.3, 88.2 };
            Console.WriteLine(values.Sum());
            Console.WriteLine(values.Min());
            Console.WriteLine(values.Max());
            Console.WriteLine(values.Average());
        }
        
        public static double Sum(this IEnumerable<Decimal> iEnum)
        {
            double sum = 0;
            foreach (double item in iEnum)
            {
                sum += item;
            }
            return (double)Convert.ToDecimal(sum);
        }
        public static double Min(this IEnumerable<Decimal> iEnum)
        {
            double min = 0;
            foreach (double item in iEnum)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return (double)Convert.ToDecimal(min);
        }
        public static double Max(this IEnumerable<Decimal> iEnum)
        {
            double max = 0;
            foreach (double item in iEnum)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return (double)Convert.ToDecimal(max);
        }
        public static double Average(this IEnumerable<Decimal> iEnum)
        {
            double sum = 0;
            double average = 0;
            foreach (var item in iEnum)
            {
                sum = sum + (double)item;
                average = sum / iEnum.Count();
            }
            return average;
        }
    }
}
