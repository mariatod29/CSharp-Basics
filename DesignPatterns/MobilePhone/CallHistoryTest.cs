using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Добавете свойство архив с обажданията – callHistory, което да пази списък от осъщест­вените разговори.
public class PhoneCallHistoryTest
{
    static Random random = new Random();
    public static void PhoneCallHistoryMethod()
    {
        MobilePhone myPhone = new MobilePhone("Samsung", "Galaxy S22", "Angel", 1200.00m);
        List<DateTime> dates = new List<DateTime>() { new DateTime(2022, 07, 07), new DateTime(2020, 06, 26), new DateTime(2019, 06, 09), new DateTime(2019, 09, 09), new DateTime(2019, 03, 09) };
        List <DateTime> times = new List<DateTime>() { new DateTime(2022, 07, 07,17,02,05), new DateTime(2020, 06, 26,23,25,41), new DateTime(2019, 06, 09,12,35,01), 
                                                        new DateTime(2019, 09, 09,14,12,32), new DateTime(2019, 03, 09,12,32,21) };
        List<string> dialNumbers = new List<string>() { "0865521563", "0985655635", "08876357533", "0888426771", "0887761142" };
        List<TimeSpan> callDurations = new List<TimeSpan>() { new TimeSpan(0, 23, 14), new TimeSpan(0, 35, 52), new TimeSpan(0, 01, 21), new TimeSpan(0, 03, 11), new TimeSpan(0, 06, 02) };
        int callCount = random.Next(1, 100);
        for (int i = 0; i < callCount; i++)
        {
            myPhone.AddCall(dates[random.Next(0, 4)], times[random.Next(0, 4)], dialNumbers[random.Next(0, 4)], callDurations[random.Next(0, 4)]);
        }
        //Създайте клас GSMCallHistoryTest, с който да се тества функционал­ността на класа GSM, от задача 12, като обект от тип GSM. След това, към него добавете няколко обаждания (Call).
        //Изведете информация за всяко едно от обажданията. Ако допуснем, че цената за минута раз­говор е 0.37, пресметнете и отпечатайте общата цена на разговорите.
        
        Console.WriteLine(myPhone.ToString(true));
        Console.WriteLine("The total amount for calls is: {0:N} lv.", myPhone.CalculateAllCosts(0.37m));
        double maximalCallDuration = myPhone.CallHistory.Max(m => m.CallDuration.TotalSeconds);
        for (int i = 0; i < myPhone.CallHistory.Count(); i++)
        {
            if (myPhone.CallHistory[i].CallDuration.TotalSeconds == maximalCallDuration)
            {
                myPhone.RemoveCalls(i, i);
                i--;
            }
        }
        //Премахнете най-дългият разговор от архива с обаждания и пресмет­нете общата цена за всички разговори отново. 
        Console.WriteLine(myPhone.ToString(true));
        Console.WriteLine("The total amount for calls is: {0:N} lv.", myPhone.CalculateAllCosts(0.37m));
        //Най-накрая изтрийте архива с обаждания.
        myPhone.ClearCallHistory();
        Console.WriteLine(myPhone.ToString(true));
        Console.WriteLine("The total amount for calls is: {0:N} lv.", myPhone.CalculateAllCosts(0.37m));
    }
}