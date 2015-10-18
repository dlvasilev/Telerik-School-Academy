using System;

// Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

namespace _13.NullValuesToIntAndDouble
{
    class NullValues
    {
        static void Main()
        {
            int intValue;
            double doubleValue;

            // Cannot be printed without values
            Console.WriteLine("Null Value of Integer: {0}", intValue);
            Console.WriteLine("Null value of Double: {0}", doubleValue);

            // They cannot be assinged with the null literal!
            intValue = null;
            doubleValue = null;

            intValue = 123;
            doubleValue = 123.45;

            // Now the can be printed
            Console.WriteLine("Value of Integer: {0}", intValue);
            Console.WriteLine("Value of Double: {0}", doubleValue);
        }
    }
}
