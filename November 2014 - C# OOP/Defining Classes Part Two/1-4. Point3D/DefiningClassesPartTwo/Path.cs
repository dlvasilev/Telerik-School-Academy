using System;
using System.Collections.Generic;

namespace PointStuff
{
    class Path
    {
        public List<Point3D> pointSeq = new List<Point3D>();

        //methods
        public void AddPoint(Point3D point)
        {
           this.pointSeq.Add(point);
        }


    }
}
