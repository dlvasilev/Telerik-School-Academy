﻿using System;

// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace _9.PointWithinACircleAndOutOfRectangle
{
    class PointWithinACircleAndOutOFRectangle
    {
        static void Main()
        {
            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());


            if (((x >= 1) && (x <= 7)) && ((y >= -1) && (y <= -3)))
            {
                Console.WriteLine("No!");
            }
            else
            {
                x = x - 1.0;
                y = y - 1.0;

                double pointPosition = Math.Sqrt((x * x) + (y * y));
                double radius = 3.0;
                bool check = (pointPosition <= radius);
                Console.WriteLine(check ? "Yes!" : "No!");
            }
        }
    }
}
