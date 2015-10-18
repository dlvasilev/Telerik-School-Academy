using System;

namespace _02.InputTenNumbers
{
    class InputTenNumbers
    {
        static void ReadNuber(int start, int end)
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} < number[{1}] < {2}: ", start, i, end);
                try
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    throw new FormatException("Not a number.", fe);
                    i--;
                }

                if (arr[i] <= start || arr[i] >= end)
                {
                    throw new ArgumentException("Invalid number");
                }

                start = arr[i];

            }

            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
        }

        static void Main()
        {
            int start = 1;
            int end = 100;
            ReadNuber(start, end);
        }
    }
}
