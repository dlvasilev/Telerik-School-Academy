using System;

// Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.

namespace _7.UseOfQuotes
{
    class UseOfQuotes
    {
        static void Main()
        {
            string firstString = "The \"use\" of quotes couses difiqulties.";
            string secondString = "The 'use' of quotes couses difiqulties.";
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
