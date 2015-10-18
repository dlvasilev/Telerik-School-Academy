using System;

namespace PointStuff
{
    struct Point3D
    {
        //fields
        static readonly Point3D O = new Point3D(0,0,0);

        //properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D returnStart
        {
            get { return O;}
        }

        //methods
        public override string ToString()
        {
            return String.Join(",", this.X, this.Y, this.Z);
        }

        public Point3D(double x, double y, double z)
            :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

    }
}
