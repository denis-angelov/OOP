using System;


namespace DefiningClassesPart1
{
    public class Battery
    {
        //fields
        string model = null;
        string hoursIdle = null;
        string hoursTalk = null;
        BatteryType batteryType = BatteryType.Other;

        //properties


        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value; }
        }

        public string HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BatteryType BatteryType

        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }


    }
    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd,
        Other
    }

}
