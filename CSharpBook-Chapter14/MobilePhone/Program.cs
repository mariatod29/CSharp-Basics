using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class MobilePhoneTest
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        MobilePhone[] myPhones = new MobilePhone[2] { new MobilePhone("13 Pro Max", "iPhone", "Maria", 1740.00m), new MobilePhone("SE 2018", "iPhone", "Kiril", 470.20m) };
        foreach (var item in myPhones)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine(MobilePhone.NokiaN95.ToString());
        PhoneCallHistoryTest.PhoneCallHistoryMethod();
    }
}