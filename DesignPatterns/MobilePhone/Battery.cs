using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// Дефинирайте клас, който съдържа информация за характеристики на батерията (модел, idle time и часове разговор /hours talk/)
public enum BatteryTypes : byte { LiOn = 1, NiCd, NiMH };

public class Battery
{
    string model;
    TimeSpan hoursIdle;
    TimeSpan hoursCall;
    BatteryTypes? batteryType = new BatteryTypes();
    public Battery(string model, BatteryTypes? batteryType)
    {
        this.model = model;
        this.batteryType = batteryType;
    }
    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value) | String.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid model input!");
            this.model = value;
        }
    }
    public TimeSpan HoursIdle
    {
        get { return this.hoursIdle; }
        set
        {
            if (value.TotalSeconds <= 0) throw new ArgumentException("Invalid IdleHours input!");
            this.hoursIdle = value;
        }
    }

    public TimeSpan HoursCall
    {
        get { return this.hoursCall; }
        set
        {
            if (value.TotalSeconds <= 0) throw new ArgumentException("Invalid CallHours input!");
            this.hoursCall = value;
        }
    }
    public BatteryTypes? BatteryType
    {
        get { return this.batteryType; }
        set
        { this.batteryType = value; }
    }
    public override string ToString()
    {
        return String.Format("Model: {0}, Battery Type: {1}, Hours Idle: {2}, Hours Call: {3}", this.Model, this.BatteryType, this.HoursIdle, this.HoursCall);
    }
}
