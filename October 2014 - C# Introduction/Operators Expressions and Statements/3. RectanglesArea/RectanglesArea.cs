using System;

// Write an expression that calculates rectangle’s area by given width and height.

namespace _3.RectanglesArea
{
    class RectanglesArea
    {
        static void Main()
        {
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is: {0}", ( width * height ) / 2 ); 
        }
    }
}
