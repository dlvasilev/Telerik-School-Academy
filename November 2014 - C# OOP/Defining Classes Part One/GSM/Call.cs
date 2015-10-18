using System;

namespace GSM
{
    class Call
    {
        private DateTime dateAndTime;
        private string dialedPhone;
        private int duration;

        //properties
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
        }

        public int Duration
        {
            get { return this.duration; }
        }

        //constructor
        public Call(DateTime DateAndTime, string DialedPhone, int Duration)
        {
            this.dateAndTime = DateAndTime;
            this.dialedPhone = DialedPhone;
            this.duration = Duration;
        }
    }
}
