namespace GSM
{

    enum BaterryType
    {
        LiIon, NiMH, NiCd
    }

    class Battery
    {
        //Private fields. Assigned defaut values just for clarity.
        private string model = null;
        private ushort hoursIdle = 0;
        private ushort hoursTalk = 0;

        public string Model
        {
            get { return this.model; }
        }
    
        //constructors
        public Battery(string Model)
        {
            this.model = Model;
        }

        public Battery(string Model, ushort HoursIdle)
            : this(Model)
        {
            this.hoursIdle = HoursIdle;
        }

        public Battery(string Model, ushort HoursIdle, ushort HoursTalk)
            : this(Model, HoursIdle)
        {
            this.hoursTalk = HoursTalk;
        }
    }
}
