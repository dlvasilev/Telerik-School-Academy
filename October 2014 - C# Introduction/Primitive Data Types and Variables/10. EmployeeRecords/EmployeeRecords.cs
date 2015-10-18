using System;
using System.Numerics;

// A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

namespace _10.EmployeeRecords
{
    class EmployeeRecords
    {
        static void Main()
        {
            Console.Write("First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lName = Console.ReadLine();
            Console.Write("Age: ");
            short age = short.Parse(Console.ReadLine());
            Console.Write("Gender(m or f): ");
            string gender = Console.ReadLine();
            Console.Write("ID Number: ");
            BigInteger idNumber = BigInteger.Parse(Console.ReadLine());
            Console.Write("Unique number(27560000 to 27569999): ");
            int uniqueNumber = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            Console.WriteLine("The employee information is: ");
            Console.WriteLine("First Name: {0}", fName);
            Console.WriteLine("Last Name: {0}", lName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("ID Number: {0}", idNumber);
            Console.WriteLine("Unique number: {0}", uniqueNumber);
        }
    }
}
