﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Дефинирайте клас, който съдържа информация за мобилен телефон: модел, производител, цена, собственик
public class MobilePhone
{
    string model;
    string manufacturer;
    decimal price;
    string owner;
    static MobilePhone nokiaN95;
    List<Call> callHistory = new List<Call>();

    //Декларирайте няколко конструктора за всеки от създадените класове от предходната задача, които имат различни списъци с параметри
    //(за цялостната информация за даден студент или част от нея).
    //Данните за полетата, които не са известни трябва да се инициализират съответно със стойности с null или 0.
    public MobilePhone(string manufacturer, string model, string owner, decimal price)
    {
        this.Manufacturer = manufacturer;
        this.Model = model;
        this.Owner = owner;
        this.Price = price;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value) | String.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid model value!");
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (String.IsNullOrEmpty(value) | String.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Invalid manufacturer value");
            this.manufacturer = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0) throw new ArgumentException("Negative price is not allowed!");
            this.price = value;
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }
    }

    //Към класа за мобилен телефон от предходните две задачи, добавете статично поле nokiaN95, което да съхранява информация за мобилен телефон модел Nokia 95.
    //Добавете метод, в същия клас, който извежда информация за това статично поле.
    public static MobilePhone NokiaN95
    {
        get { return new MobilePhone("Nokia", "N95", "young teenager", 998.00m); }
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { value = this.callHistory; }
    }
    public MobilePhone(string manufacturer, string model, Battery battery, Display display)
            : this(manufacturer, model, null, 0m)
    {
        this.battery = null;
        this.display = null;
    }
    Display display = new Display(16.8f, 32000);
    Battery battery = new Battery("China", BatteryTypes.LiOn);

    public static void PrintGSMInfo(MobilePhone myPhone)
    {
        Console.WriteLine(myPhone.ToString());
    }

    public override string ToString()
    {
        StringBuilder GSMInfo = new StringBuilder();
        GSMInfo.AppendLine(String.Format("GSM Manufacturer: {0}", this.Manufacturer));
        GSMInfo.AppendLine("GSM Model: " + this.Model);
        GSMInfo.AppendLine("GSM Battery: " + this.battery.ToString());
        GSMInfo.AppendLine("GSM Display: " + this.display.ToString());
        GSMInfo.AppendLine("GSM Price: " + this.Price);
        GSMInfo.AppendLine("GSM Owner: " + this.Owner);
        return GSMInfo.ToString();
    }

    public string ToString(bool showCallHistory)
    {
        if (!showCallHistory) return ToString();
        else
        {
            StringBuilder callHistoryInfo = new StringBuilder();
            callHistoryInfo.AppendLine(ToString());
            if (this.callHistory != null)
            {
                for (int i = 0; i < this.callHistory.Count; i++)
                {
                    callHistoryInfo.AppendLine((i + 1) + " " + callHistory[i].ToString());
                }
            }
            return callHistoryInfo.ToString();
        }
    }
    //В класа GSM добавете методи за добавяне и изтриване на обаждания (Call) в архива с обаждания на мобилния телефон.
    public void AddCall(DateTime date, DateTime time, string phoneNumber, TimeSpan callDuration)
    {
        this.callHistory.Add(new Call(date, time, phoneNumber, callDuration));
    }

    public void RemoveCalls(int start, int end)
    {
        this.callHistory.RemoveRange(start, end - start + 1);
    }
    //Добавете метод, който изтрива всички обаждания от архива.
    public void ClearCallHistory()
    {
        Console.Write("This will delete all calls in the history! Proceed? y/n :");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            this.callHistory.Clear();
        }
        else return;
    }
    //В класа GSM добавете метод, който пресмята общата сума на обажда­нията (Call) от архива с обаждания на телефона (callHistory) като нека
    //цената за едно обаждане се подава като параметър на метода.
    public decimal CalculateAllCosts(decimal minutePrice)
    {
        return minutePrice * (decimal)this.callHistory.Sum(c => c.CallDuration.TotalSeconds) / 60;
    }
}