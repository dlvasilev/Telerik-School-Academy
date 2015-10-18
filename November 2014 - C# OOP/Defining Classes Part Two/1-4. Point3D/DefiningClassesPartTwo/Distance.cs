using System;

namespace PointStuff
{
    static class Distance
    {
        public static double CalcDistance(Point3D startPoint, Point3D endPoint)
        {
            return Math.Sqrt(Math.Pow(startPoint.X - endPoint.X, 2) + Math.Pow(startPoint.Y - endPoint.Y, 2) + Math.Pow(startPoint.Z - endPoint.Z, 2));
        }
    }
}
