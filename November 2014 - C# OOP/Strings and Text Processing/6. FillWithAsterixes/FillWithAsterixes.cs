using System;

namespace _06.FillWithAsterixes
{
    class FillWithAsterixes
    {
        static void PadString()
        {
            Console.Write("Input string: ");
            string str = Console.ReadLine();
            if (str.Length > 20)
            {
                Console.WriteLine("Invalid string. It must not me longer than 20 characters.");
                PadString(); //recursively making the user input his string again if it isn't valid.
                return; //not really the best working way, but I think is Okay for this simple exercise.
            }
            string result = str.PadRight(20, '*');
            Console.WriteLine(result);
        }

        static void Main()
        {
            PadString();
        }
    }
}
