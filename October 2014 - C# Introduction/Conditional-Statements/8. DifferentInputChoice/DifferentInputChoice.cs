using System;

// Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

namespace _8.DifferentInputChoice
{
    class DifferentInputChoice
    {
        static void Main()
        {
            Console.Write("Please choose what to input: 1 for int, 2 for double, 3 for string: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int integerChoice= int.Parse(Console.ReadLine());
                    Console.WriteLine("The output is: {0}", integerChoice + 1);
                    break;
                case 2:
                    double doubleChoice = double.Parse(Console.ReadLine());
                    Console.WriteLine("The output is: {0}", doubleChoice + 1.0D);
                    break;
                case 3:
                    string stringChoice = Console.ReadLine();
                    Console.WriteLine("The output is: {0}", stringChoice + "*");
                    break;
            }
        }
    }
}
