using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//Създайте клас Call, който съдържа информация за разговор, осъщес­твен през мобилен телефон.
//Той трябва да съдържа информация за датата, времето на започване и продължителността на разговора.
public class Call
{
    DateTime date;
    DateTime time;
    string phoneNumber;
    TimeSpan callDuration;

    public DateTime Date
    {
        get { return this.date; }
        set
        { this.date = value; }
    }
    public DateTime Time
    {
        get { return this.time; }
        set { this.time = value; }
    }
    public string PhoneNumber
    {
        get { return this.phoneNumber; }
        set
        {
            Regex cellValidation = new Regex(@"[^0-9\-\+\)\(]");
            if (cellValidation.IsMatch(value) || String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value)) throw new ArgumentException("The phone number must be just numbers!");
            this.phoneNumber = value;
        }
    }
    public TimeSpan CallDuration
    {
        get { return this.callDuration; }
        set
        {
            if (value.Seconds <= 0) throw new ArgumentException("Invalid call duration!");
            this.callDuration = value;
        }
    }
    public Call(DateTime date, DateTime time, string phoneNumber, TimeSpan callDuration)
    {
        this.Date = date;
        this.Time = time;
        this.PhoneNumber = phoneNumber;
        this.CallDuration = callDuration;
        
    }
    public override string ToString()
    {
        StringBuilder callInfo = new StringBuilder();
        callInfo.Append(this.Date.ToShortDateString() + ", " + this.Time.ToShortTimeString() + ", " + this.PhoneNumber + ", " + this.callDuration.TotalSeconds);
        return callInfo.ToString();
    }
}