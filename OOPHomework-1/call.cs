using System;


namespace DefiningClassesPart1
{

    //Problem 8. Calls

    public class Call
    {
        public DateTime date;
        public DateTime time;
        private int dialedPhoneNumber;
        private int duration;

        public Call(DateTime Date, DateTime Time, int DealedPhoneNumber, int Duration)
        {
            this.date = Date;
            this.time = Time;
            this.dialedPhoneNumber = DealedPhoneNumber;
            this.duration = Duration;
        }


    }
}
