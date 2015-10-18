namespace GSM
{
    class Display
    {
        //Private fields. Assigned defaut values just for clarity.
        private double size;
        private int colorCount;

        //constructors
        public Display()
        {

        }

        public Display(double Size)
        {
            this.size = Size;
        }

        public Display(double Size, int ColorCount)
            : this(Size)
        {
            this.colorCount = ColorCount;
        }
    }
}
