using System;
using System.Text;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();

            StringBuilder reversedStr = new StringBuilder();

            int lenght = str.Length - 1;
            for (int i = lenght; i >= 0; i--)
            {
                reversedStr.Append(str[i]);   
            }
            Console.WriteLine(reversedStr);
        }
    }
}
