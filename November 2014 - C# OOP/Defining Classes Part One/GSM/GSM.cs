using System;
using System.Collections.Generic;

namespace GSM
{
    public class GSM
    {
        //Private fields. Assigned defaut values just for clarity.
        private string model = null;
        private string manufacturer = null;
        private int price = 0;
        private string owner = "unknown";

        private static GSM iPhone4S = new GSM("iPhone 4S","Apple", 400, "Bill Gates");

        private List<Call> CallHistory = new List<Call>();

        private int pricePerMinute;

        public int PricePerMinute
        {
            get { return this.pricePerMinute; }
            set { this.pricePerMinute = value; }
        }

        //properties
        public static GSM IPhone4S
        {
            get { return iPhone4S;}
        }

        public string Model
        {
            get { return this.model; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
        }

        public int Price
        {
            get { return this.price; }
        }

        public string Owner
        {
            get { return this.owner; }
        }

        //Methods
        public override string ToString()
        {
            Console.WriteLine("GSM Info: ");
            Console.WriteLine("Model: {0} .",this.model);
            Console.WriteLine("Manufacturer: {0} .", this.manufacturer);
            Console.WriteLine("Price: {0} .", this.price);
            Console.WriteLine("Owner: {0} .", this.owner);
            return base.ToString();
        }


        public void AddCall(DateTime dateAndtime, string dialedPhone, int duration)
        {
            CallHistory.Add(new Call(dateAndtime, dialedPhone, duration));
        }

        public void RemoveCall(int duration) //Remove a certain call
        {
            for (int i = 0; i < CallHistory.Count; i++ )
            {
                if (CallHistory[i].Duration == duration)
                {
                    this.CallHistory.RemoveAt(i);
                }
            }
        }

        public void RemoveLongestCall()
        {
            int longest = CallHistory[0].Duration;
            for (int i = 1; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].Duration > longest)
                {
                    longest = CallHistory[i].Duration;
                }
            }
            RemoveCall(longest);
        }

        public void ClearCalls()
        {
            CallHistory.Clear();
        }

        //Method for calculation bill
        public double CalcBill(double pricePerMinute)
        {
            double bill = 0;
            double callPrice = 0;
            foreach (var call in CallHistory)
            {
                callPrice = (call.Duration * pricePerMinute) / 60;
                bill += callPrice;
            }
            return bill;
        }

        public void PrintCalls()
        {
            foreach (var call in CallHistory)
            {
                Console.WriteLine("{0} - {1} - {2} seconds",call.DateAndTime,call.DialedPhone,call.Duration);
                
            }
        }

        //constructors
        public GSM(string Model, string Manufacturer)
        {
            this.model = Model;
            this.manufacturer = Manufacturer;
        }

        public GSM(string Model, string Manufacturer, int Price)
            : this(Model, Manufacturer)
        {
            this.price = Price;
        }

        public GSM(string Model, string Manufacturer, int Price, string Owner)
            : this(Model,Manufacturer,Price)
        {
            this.owner = Owner;
        }

    }
}
