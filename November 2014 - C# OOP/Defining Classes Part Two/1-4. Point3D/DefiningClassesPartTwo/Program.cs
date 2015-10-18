using System;
using System.IO;

namespace PointStuff
{
    class TestingGround
    {
        static void Main()
        {
            //testing
            Path path = new Path();
            foreach (var item in path.pointSeq)
            {
                Console.WriteLine(item);
            }
            Point3D point1 = new Point3D(0, 1, 2);
            Point3D point2 = new Point3D(3, 4, 5);

            path.AddPoint(point1);
            path.AddPoint(point2);

            foreach (var item in path.pointSeq)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Distance.CalcDistance(point1, point2));
        }
    }
}
