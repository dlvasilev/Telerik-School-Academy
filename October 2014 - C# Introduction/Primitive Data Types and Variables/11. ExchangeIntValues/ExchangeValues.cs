using System;

// Declare two integer variables and assign them with 5 and 10 and after that exchange their values.

namespace _11.ExchangeIntValues
{
    class ExchangeValues
    {
        static void Main()
        {
            Console.Write("First Number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Second Number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine("After exchange the first numer is {0} and the second is {1}", firstNumber, secondNumber);
        }
    }
}
